using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServicioServerHoraFecha
{
    public partial class ServicioServerFechaHora : ServiceBase
    {
        private static Socket s;
        private static int port;
        private int defaultPort = 31416;

        public ServicioServerFechaHora()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            writeEvent("Iniciando servidor con puerto: " + readPort());
            Thread t = new Thread(initServer);
            t.IsBackground = true;
            t.Start();
        }

        protected override void OnStop()
        {
            writeEvent("Deteniendo servidor...");
            stopServer();
        }

        public void writeEvent(string mensaje)
        {
            string nombre = "ServicioServerFechaHora";
            string logDestino = "Application";

            if (!EventLog.SourceExists(nombre))
            {
                EventLog.CreateEventSource(nombre, logDestino);
            }

            EventLog.WriteEntry(nombre, mensaje);
        }

        public bool validatePort(string input)
        {
            if (int.TryParse(input, out port)
                && port >= 49152
                && port <= 65535)
            {
                return true;
            }
            return false;
        }

        public int readPort()
        {
            string route = Environment.GetEnvironmentVariable("PROGRAMDATA");
            if (File.Exists(route + "/defaultPort.txt"))
            {
                using (StreamReader pwr = new StreamReader(route + "/defaultPort.txt"))
                {
                    if (validatePort(pwr.ReadToEnd()))
                    {
                        return port;
                    } else
                    {
                        writeEvent("El número de puerto del archivo de configuración no es válido, usando el puerto default: " + defaultPort);
                    }
                }
            } else
            {
                writeEvent("No se ha encontrado archivo de configuración, utilizando puerto por defecto: " + defaultPort);
            }
            port = defaultPort;
            return port;
        }

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
