using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_1
{
    internal class Empleado : Persona
    {
        private double salario;
        public double Salario
        {
            set
            {
                salario = value;
                if (salario < 600)
                {
                    irpf = 7;
                } else if (salario > 600 && salario <= 3000)
                {
                    irpf = 15;
                } else
                {
                    irpf = 20;
                }
            }

            get
            {
                return salario;
            }
        }

        private double irpf;
        private double Irpf
        {
            get
            {
                return irpf;
            }
        }

        private string telefono;
        public string Telefono
        {
            set
            {
                telefono = value;
            }

            get
            {
                return "+34" + telefono;
            }
        }



        public override double hacienda()
        {
            return Irpf * Salario / 100;
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.Write("Salario: {0}\nIRPF: {1}%\nTeléfono: {2}\n", Salario, Irpf, Telefono);
        }

        public void mostrarDatos(int num)
        {
            switch (num)
            {
                case 0:
                    Console.Write("Nombre: " + Nombre + "\n");
                    break;
                case 1:
                    Console.Write("Apellidos: " + Apellidos + "\n");
                    break;
                case 2:
                    Console.Write("Edad: " + Edad + "\n");
                    break;
                case 3:
                    Console.Write("DNI: " + Dni + "\n");
                    break;
                case 4:
                    Console.Write("Salario: " + Salario + "\n");
                    break;
                case 5:
                    Console.Write("IRPF: " + Irpf + "\n");
                    break;
                case 6:
                    Console.Write("Teléfono: " + Telefono + "\n");
                    break;
                default:
                    Console.Write("Valor fuera del rango. Probar con uno de los siguientes:\n0: Nombre\n1: Apellidos\n2: Edad\n3: DNI\n4: Salario\n5: IRPF\n6: Teléfono\n");
                    break;
            }
        }

        public override void introducirDatos()
        {
            base.introducirDatos();
            Console.Write("Introduzca un salario:\n");
           // string aux = Console.ReadLine();
            Salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca un teléfono:\n");
            Telefono = Console.ReadLine();
        }

        public Empleado (string nombre, string apellidos, int edad, string dni, double salario, string telefono)
            : base (nombre, apellidos, edad, dni)
        {
            Salario = salario;
            Telefono = telefono;
        }

        public Empleado()
            : this("", "", 0, "", 0, "")
        {
        }
    }
}
