using System.Net.Sockets;
using System.Net;
using System.Collections;

namespace chatroom_server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            init();
        }

        public static void init()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);
            Socket s = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            List<Usuario> usuarios = new List<Usuario>();
            s.Bind(ie);
            s.Listen(10);
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
            string mensaje;
            Socket cliente = ((Usuario)usuario).Socket;
            IPEndPoint ieCliente = (IPEndPoint) cliente.RemoteEndPoint;
            Console.WriteLine("Connected with client {0} at port {1}",
                ieCliente.Address, ieCliente.Port);

            using (NetworkStream ns = new NetworkStream(cliente))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine("Bienvenido al server de chatear y no programar, ¡que disfrutes tu procastinación!");
                sw.Flush();

                while (true)
                {
                    try
                    {
                        mensaje = sr.ReadLine();
                        sw.WriteLine(mensaje);
                        sw.Flush();
                        //El mensaje es null al cerrar
                        if (mensaje != null)
                        {
                            Console.WriteLine("{0} says: {1}",
                            ieCliente.Address, mensaje);
                        }
                    }
                    catch (IOException)
                    {
                        //Salta al acceder al socket
                        //y no estar permitido
                        break;
                    }
                }
                Console.WriteLine("Finished connection with {0}:{1}",
                    ieCliente.Address, ieCliente.Port);
            }
            cliente.Close();

        }
    }
}