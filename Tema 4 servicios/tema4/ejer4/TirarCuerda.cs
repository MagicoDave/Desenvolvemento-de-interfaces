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

        Thread t1 = new Thread(() =>
        {
            while (bandera)
            {
                lock (l)
                {
                    cuerda++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(cuerda);
                    Console.ResetColor();
                }
            }
        });
        Thread t2 = new Thread(() =>
        {
            while (bandera)
            {
                lock (l)
                {
                    cuerda--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(cuerda);
                    Console.ResetColor();
                }
            }
        });

        public void jugar()
        {
            t1.Start();
            t2.Start();

            while (bandera)
            {
                if (cuerda >= 1000 || cuerda <= -1000)
                {
                    bandera = false;

                    if (cuerda >= 1000)
                    {
                        Console.WriteLine("\n El primer hilo gana");
                    }
                    else
                    {
                        Console.WriteLine("\n El segundo hilo gana");
                    }

                }
            }
        }
    }
}
