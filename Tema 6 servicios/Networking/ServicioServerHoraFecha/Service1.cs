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

        private int defaultPort = 31416;

        public ServicioServerFechaHora()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            writeEvent("Iniciando servidor con puerto: " + readPort());
            Thread t = new Thread(Server.initServer);
            t.IsBackground = true;
            t.Start();
        }

        protected override void OnStop()
        {
            writeEvent("Deteniendo servidor...");
            Server.stopServer();
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
            if (int.TryParse(input, out Server.port)
                && Server.port >= 49152
                && Server.port <= 65535)
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
                        return Server.port;
                    } else
                    {
                        writeEvent("El número de puerto del archivo de configuración no es válido, usando el puerto default: " + defaultPort);
                    }
                }
            } else
            {
                writeEvent("No se ha encontrado archivo de configuración, utilizando puerto por defecto: " + defaultPort);
            }
            Server.port = defaultPort;
            return Server.port;
        }
    }
}
