using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServicioServerHoraFecha
{
    internal class Server
    {

        public static Socket s;
        public static int port;

        public static void initServer()
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, port);
            string route = Environment.GetEnvironmentVariable("PROGRAMDATA");
            string pw;
            bool runningStatus = true;

            using (s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp))
            {

                s.Bind(ie);
                s.Listen(10);
                Console.WriteLine($"Server listening at port:{ie.Port}");

                while (runningStatus)
                {
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
                                if (msg != null && msg.StartsWith("close"))
                                {
                                    Console.WriteLine("Client sent: " + msg);
                                    using (StreamReader pwr = new StreamReader(route + "/pwEjer1.txt"))
                                    {
                                        pw = pwr.ReadToEnd();
                                    }

                                    if (msg == "close " + pw)
                                    {
                                        sw.WriteLine("The server will close...");
                                        sw.Flush();
                                        sClient.Close();
                                        s.Close();
                                        runningStatus = false;
                                    }
                                    else if (msg.Trim() == "close")
                                    {
                                        sw.WriteLine("Empty password. Try again");
                                    }
                                    else
                                    {
                                        sw.WriteLine("Wrong password. Try again");
                                    }
                                    sw.Flush();
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
                                            sw.WriteLine("Command " + msg + " does not exist");
                                            break;
                                    }
                                    sw.Flush();
                                }
                                msg = null;
                            }
                            catch (FileNotFoundException e)
                            {
                                pw = "1234";
                            }
                            catch (IOException e)
                            {
                                msg = null;
                            }
                            catch (ArgumentNullException e)
                            {
                                msg = null;
                            }
                        }
                        sClient.Close();
                    }
                }

            }

        }

        public static void stopServer()
        {
            if (s != null)
            {
                s.Close();
            }
        }
    }
}
