﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_1
{
    internal class Directivo : Persona
    {
        private string departamento;
        public string Departamento
        {
            set
            {
                departamento = value;
            }

            get
            {
                return departamento;
            }
        }

        private double beneficios;
        public double Beneficios
        {
            get
            {
                return beneficios;
            }
        }

        private int subordinados;
        public int Subordinados
        {
            set
            {
                subordinados = value;
                if (subordinados > 10)
                {
                    beneficios = 2;
                } else if (subordinados > 50)
                {
                    beneficios = 4;
                } else
                {
                    beneficios = 3.5;
                }
            }

            get
            {
                return subordinados;
            }
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.Write("Departamento: {0}\nPorcentaje de beneficios: {1}%\nNúmero de subordinados: {2}\n", Departamento, Beneficios, Subordinados);
        }

        public override void introducirDatos()
        {
            base.introducirDatos();
            Console.Write("Introduzca un departamento: \n");
            Departamento = Console.ReadLine();
            Console.Write("Introzuca número de subordinados: \n");
            string aux = Console.ReadLine();
            Subordinados = Convert.ToInt32(aux);
        }

        public static Directivo operator --(Directivo jefe)
        {
            if (jefe.Beneficios >= 1)
            {
                jefe.beneficios--;
            } else
            {
                jefe.beneficios = 0;
            }
            return jefe;
        }


        public override double hacienda()
        {
            throw new NotImplementedException();
        }

        public Directivo(string nombre, string apellido, int edad, string dni, string departamento, int subordinados)
            : base(nombre, apellido, edad, dni)
        {
            Departamento = departamento;
            Subordinados = subordinados;
        }

        public Directivo()
            : this("", "", 0, "", "", 0)
        {
        }
    }
}
