using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    internal class TirarCuerda
    {
        public static int cuerda = 0;
        public static bool bandera = true;
        static readonly private object l = new object();

        public int Cuerda
        {
            get => cuerda;
        }

        Thread t1 = new Thread(() =>
        {
            while (bandera)
            {
                lock (l)
                {
                    if (bandera)
                    {
                        cuerda++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(cuerda);
                        Console.ResetColor();

                        if (cuerda >= 1000)
                        {
                            bandera = false;
                        }
                    }
                    
                }
            }
        });
        Thread t2 = new Thread(() =>
        {
            while (bandera)
            {
                lock (l)
                {
                    if (bandera)
                    {
                        cuerda--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(cuerda);
                        Console.ResetColor();

                        if (cuerda <= -1000)
                        {
                            bandera = false;
                        }
                    }
                }
            }
        });

        public void jugar()
        {
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
    }
}
