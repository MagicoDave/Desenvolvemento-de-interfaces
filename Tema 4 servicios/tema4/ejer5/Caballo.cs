using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5
{
    internal class Caballo
    {
        private int[] posicion = new int[2];
        private string nombre;
        public Thread thread;
        static public bool bandera = true;

        static readonly private object l = new object();

        private void correr()
        {
            Random generador = new Random();
            bandera = true;

            while (bandera) 
            {
                lock (l)
                {
                    if (bandera)
                    {
                        for (int i = 0; i < generador.Next(4); i++)
                        {
                            Console.SetCursorPosition(Posicion[0], Posicion[1]);
                            Console.Write("*");
                            Posicion[0]++;
                        }

                        if (Posicion[0] >= 100)
                        {
                            Console.SetCursorPosition(0, 13);
                            Console.Write("¡" + Nombre + " ha ganado!");
                            bandera = false;
                        }
                    }      
                }

                Thread.Sleep(generador.Next(100, 201));
            }

        }

        public int[] Posicion
        {
            get => posicion;
            set => posicion = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public Caballo(int[] posicion, string nombre)
        {
            Posicion = posicion;
            thread = new Thread(correr);
            this.nombre = nombre;
        }
    }
}
