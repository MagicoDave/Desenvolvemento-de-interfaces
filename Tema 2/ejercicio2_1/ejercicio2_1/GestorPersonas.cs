using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_1
{
    internal class GestorPersonas
    {
        private List<Persona> coleccionPersonas;

        public List<Persona> ColeccionPersonas
        {
            set => coleccionPersonas = value;
            get => coleccionPersonas;
        }

        public int Posicion (int edad)
        {
            foreach (Persona persona in ColeccionPersonas)
            {
                if (persona.Edad < edad)
                {
                    return ColeccionPersonas.IndexOf(persona);
                }
            }

            return -1;
        }

        public int Posicion (string cadena)
        {
            foreach (Persona persona in ColeccionPersonas)
            {
                if (persona.Apellidos.Contains(cadena))
                {
                    return ColeccionPersonas.IndexOf(persona);
                }
            }

            return -1;
        }

        public bool Eliminar (int max, int min = 0)
        {
            if (max > ColeccionPersonas.Count || min < ColeccionPersonas.Count)
            {
                return false;
            }

            foreach (Persona persona in coleccionPersonas)
            {
                if (ColeccionPersonas.IndexOf(persona) > min && ColeccionPersonas.IndexOf(persona) < max)
                {
                    ColeccionPersonas.Remove(persona);
                }
            }

            return true;
        }
        
    }
}
