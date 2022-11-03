using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer6
{
    internal class MyTimer
    {
        public int interval;
        public delegate void d();
        public d delegado;
        public Thread thread;
        private bool flag;

        static readonly object l = new object();

        public void run()
        {
            lock (l)
            {
                flag = true;
                Monitor.Pulse(l);
            }
        }

        public void pause()
        {
            lock (l)
            {
                flag = false;
            }
        }

        private void loop()
        {
            while (true)
            {                
                lock (l)
                {
                    if (!flag)
                    {
                        Monitor.Wait(l);
                    }
                    delegado.Invoke();
                }
                Thread.Sleep(interval);
            }
        }

        public MyTimer(d funcion)
        {
            delegado = new d(funcion);
            thread = new Thread(loop);
            thread.Start();
            thread.IsBackground = true;
            pause();
        }
    }
}
