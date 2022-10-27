using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    internal class Display
    {
        private int[] position = new int[2];
        private string[] bar = {"|", "/", "-", "\\"};
        private int n;
        public Thread thread;
        public bool flag;
        public bool pause;

        object l;

        private void spin()
        {
            while (flag)
            {
                lock (l)
                {
                    if (flag)
                    {
                        if (pause)
                        {
                            Monitor.Wait(l);
                        }
                        if (n > 3)
                        {
                            n = 0;
                        }
                        Console.SetCursorPosition(position[0], position[1]);
                        Console.Write(string.Format("{0}", bar[n]));
                        n++;
                    }
                }
                Thread.Sleep(200);
            }
        }

        public Display(int[] position, object l)
        {
            this.position = position;
            n = 0;
            flag = true;
            this.l = l;
            thread = new Thread(spin);
        }
    }
}
