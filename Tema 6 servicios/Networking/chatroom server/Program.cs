using System.Net.Sockets;
using System.Net;
using System.Collections;
using System.Diagnostics;

namespace chatroom_server
{
    internal class Program
    {

        static readonly private object l = new object();
        static List<Usuario> usuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            init();
        }

        public static void init()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);
            Socket s = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);

            try
            {
                s.Bind(ie);
                s.Listen(10);
            }
            catch (SocketException e)
            {
                Debug.WriteLine("Socket Exception: " + e.Message);
            }
            
            Console.WriteLine("Server waiting at port {0}", ie.Port);

            while (true)
            {
                Socket cliente = s.Accept();
                Usuario usuario = new Usuario(cliente);
                usuarios.Add(usuario);
                Thread hilo = new Thread(hiloCliente);
                hilo.Start(usuario);
            }
        }

        public static void hiloCliente(object usuario)
        {
            Usuario u = (Usuario) usuario;
            string mensaje;
            Socket cliente = u.Socket;
            IPEndPoint ieCliente = (IPEndPoint) cliente.RemoteEndPoint;
            Console.WriteLine("Connected with client {0} at port {1}",
                ieCliente.Address, ieCliente.Port);

            using (NetworkStream ns = new NetworkStream(cliente))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                while (u.EstaConectado)
                {
                    if (!u.EstaRegistrado && u.EstaConectado)
                    {
                        u = registrarUsuario(u, sr, sw);
                        sw.WriteLine("Bienvenido al server de chatear en clase y no programar, ¡que disfrutes tu procastinación!");
                        sw.Flush();
                    }

                    int codigoRespuesta = recibirMensaje(sr, out mensaje);

                    lock (l)
                    {
                        switch (codigoRespuesta)
                        {
                            case -1:
                                u = gestionarMensaje(u, sw, "#EXIT");
                                break;
                            case 0:
                                u = gestionarMensaje(u, sw, mensaje);
                                break;
                            case 1:
                                break;
                        }
                    }
                }
                Debug.WriteLine("Finished connection with {0}:{1}",
                    ieCliente.Address, ieCliente.Port);
            }
            cliente.Close();

        }

        public static int recibirMensaje(StreamReader sr, out string mensaje)
        {
            try
            {
                mensaje = sr.ReadLine();

                if (mensaje == "")
                {
                    return 1;
                }

                if (mensaje == null)
                {
                    return -1;
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine("Readline problem: " + e.Message);
                mensaje = "";
                return -1;
            }

            return 0;
        }

        public static Usuario gestionarMensaje(Usuario u, StreamWriter sw, string mensaje)
        {
            switch (mensaje.ToUpper())
            {
                case "#LIST":
                    try
                    {
                        sw.WriteLine("Usuarios conectados: \n");
                        foreach (Usuario usuario in usuarios)
                        {
                            sw.WriteLine(usuario.AliasCompleto);
                        }
                        sw.Flush();
                    }
                    catch (IOException e)
                    {
                        Debug.WriteLine(e.Message);
                    }
                    break;
                case "#EXIT":
                    usuarios.Remove(u);
                    mandarMensaje(u, "Este usuario se ha desconectado");
                    u.EstaConectado = false;
                    break;
                default:
                    mandarMensaje(u, mensaje);
                    break;
            }

            return u;
        }

        public static void mandarMensaje(Usuario u, string mensaje)
        {
            foreach (var usuario in usuarios)
            {
                try
                {
                    using (NetworkStream ns = new(usuario.Socket))
                    using (StreamReader sr = new(ns))
                    using (StreamWriter sw = new(ns))
                    {
                        sw.WriteLine(u.AliasCompleto + ": " + mensaje);
                        sw.Flush();
                    }
                }
                catch (IOException e)
                {
                    Debug.WriteLine(e.Message);
                }

            }
        }

        public static Usuario registrarUsuario(Usuario u, StreamReader sr, StreamWriter sw)
        {
            sw.WriteLine("Introduce tu nombre de usuario:");
            sw.Flush();

            try
            {
                u.Alias = sr.ReadLine();
            }
            catch (IOException e)
            {
                Debug.WriteLine("Readline problem: " + e.Message);
                return u;
            }

            if (u.Alias == null)
            {
                u.EstaConectado = false;
                return u;
            }

            if (u.Alias == "")
            {
                sw.WriteLine("Nombre de usuario no válido");
                sw.Flush();
            } else
            {
                sw.WriteLine("Registrado correctamente con nombre de usuario: " + u.Alias);
                sw.Flush();
                try
                {
                    u.AliasCompleto = u.Alias + "@" + (u.Socket.RemoteEndPoint as IPEndPoint).Address.ToString();
                }
                catch (SocketException e)
                {
                    Debug.WriteLine("Socket Exception: " + e.Message);
                }
                u.EstaRegistrado = true;
                mandarMensaje(u, "Se ha conectado");
            }

            return u;
            
        }
    }
}