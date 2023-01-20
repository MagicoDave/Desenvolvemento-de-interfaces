using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;

namespace Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416);

            using (Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp))
            {
                s.Bind(ie);
                s.Listen(10);
                Console.WriteLine($"Server listening at port:{ie.Port}");
                Socket sClient = s.Accept();

                IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
                Console.WriteLine("Client connected:{0} at port {1}", ieClient.Address,
                    ieClient.Port);

                using (NetworkStream ns = new NetworkStream(sClient))
                using (StreamReader sr = new StreamReader(ns))
                using (StreamWriter sw = new StreamWriter(ns))
                {
                    string msg = "";
                    while (msg != null)
                    {
                        try
                        {
                            msg = sr.ReadLine();
                            if (msg.StartsWith("close "))
                            {

                            }
                            else
                            {
                                string hora = DateTime.Now.ToString("h:mm:ss tt");
                                string fecha = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
                                switch (msg)
                                {
                                    case "time":
                                        sw.WriteLine(hora);
                                        break;
                                    case "date":
                                        sw.WriteLine(fecha);
                                        break;
                                    case "all":
                                        sw.WriteLine(fecha + " " + hora);
                                        break;
                                    default:
                                        sw.WriteLine("Comando no valido");
                                        break;
                                }
                                sw.Flush();
                            }
                        }
                        catch (IOException e)
                        {
                            msg = null;
                        }
                    }
                }
            }
            
            
            
            
            
            
            
            

            
        }
    }
}