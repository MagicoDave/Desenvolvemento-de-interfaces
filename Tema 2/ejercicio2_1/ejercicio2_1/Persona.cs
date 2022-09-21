using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_1
{
    abstract class Persona
    {
        private string nombre;
        public string Nombre
        {
            set
            {
                nombre = value;
            }

            get
            {
                return nombre;
            }
        }

        private string apellidos;
        public string Apellidos
        {
            set
            {
                apellidos = value;
            }

            get
            {
                return apellidos;
            }
        }

        private int edad;
        public int Edad
        {
            set
            {
                if (value > 0)
                {
                    edad = value;
                }
                else
                {
                    edad = 0;
                }
            }
            get
            {
                return edad;
            }
        }

        private string dni;
        public string Dni
        {
            set
            {
                if (value.Length > 8)
                {
                    dni = value.Substring(0, 8);
                } else
                {
                    dni = value;
                }
         
            }
            get
            {
                
                string[] letrasDni = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                int aux = 0;
                try
                {
                    aux = Convert.ToInt32(dni);
                }
                catch (Exception e)
                {
                    Console.Write(e.StackTrace + "\n");
                }
                return dni + letrasDni[aux%23];
            }
        }

        public virtual void mostrarDatos()
        {
            Console.Write("Nombre: {0}\nApellidos: {1}\nEdad: {2}\nDNI: {3}\n", Nombre, Apellidos, Edad, Dni);
        }

        public virtual void introducirDatos()
        {
            Console.Write("Introduzca un nombre:\n");
            Nombre = Console.ReadLine();
            Console.Write("Introduzca un apellido:\n");
            Apellidos = Console.ReadLine();
            Console.Write("Introduzca una edad:\n");
            string aux = Console.ReadLine();
            Edad = Convert.ToInt32(aux);
            Console.Write("Introduzca un DNI:\n");
            Dni = Console.ReadLine();
        }

        public Persona(string nombre, string apellidos, int edad, string dni)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Dni = dni;
        }

        public Persona()
            : this("", "", 0, "")
        {
        }

        public abstract double hacienda();
    }
}
