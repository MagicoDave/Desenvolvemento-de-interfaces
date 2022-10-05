using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Menu
    {
        private Aula clase;

        public Aula Clase
        {
            set => clase = value;
            get => clase;
        }

        public Menu (params string[] nombres)
        {
            Clase = new Aula(nombres);
        }
    }
}
