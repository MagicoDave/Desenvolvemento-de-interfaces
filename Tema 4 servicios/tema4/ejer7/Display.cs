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

        private void spin()
        {
            while (flag)
            {
                lock (Game.l)
                {
                    if (flag)
                    {
                        if (pause)
                        {
                            Monitor.Wait(Game.l);
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

        public Display(int[] position)
        {
            this.position = position;
            n = 0;
            flag = true;
            thread = new Thread(spin);
        }
    }
}
