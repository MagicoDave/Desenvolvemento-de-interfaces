using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDePruebas
{
    public partial class ServicioServidorFechaHora : ServiceBase
    {
        // Constructor donde se inicializan algunas propiedades de interés
        public ServicioServidorFechaHora()
        {
            InitializeComponent();
        }

        public void writeEvent(string mensaje)
        {
            string nombre = "SimpleService";
            string logDestino = "Application";

            if (!EventLog.SourceExists(nombre))
            {
                EventLog.CreateEventSource(nombre, logDestino);
            }

            EventLog.WriteEntry(nombre, mensaje);
        }

        private int t = 0;
        public void TimerTick(object sender, System.Timers.ElapsedEventArgs args)
        {
            writeEvent(string.Format($"SimpleService lleva corriendo {t} segundos"));
            t += 10;
        }

        //Se ejecuta cuando inicia el servicio
        protected override void OnStart(string[] args)
        {
            writeEvent("Running OnStart");
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 10000; //10 segundos
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.TimerTick);
            timer.Start();
        }

        //Se ejecuta cuando para el servicio
        protected override void OnStop()
        {
            writeEvent("Deteniendo SimpleService");
            t = 0;
        }

        //Se ejecuta cuando pausa el servicio
        protected override void OnPause()
        {
            writeEvent("SimpleService en pausa");
        }
        //Se ejecuta cuando continua tras la pausa el servicio
        protected override void OnContinue()
        {
            writeEvent("Reanudando SimpleService");
        }
    }
}
