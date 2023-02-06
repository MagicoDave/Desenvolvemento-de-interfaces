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

        }
    }
}