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
        public string nombre
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
        public string apellidos
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
        public int edad
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
        public string dni
        {
            set
            {


                dni = value;
            }
            get
            {
                return dni;
            }
        }
    }
}
