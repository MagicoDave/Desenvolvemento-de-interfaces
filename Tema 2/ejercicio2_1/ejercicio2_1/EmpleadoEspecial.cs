using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_1
{
    internal class EmpleadoEspecial : Empleado, IPastaGansa
    {
        double IPastaGansa.ganarPasta(double beneficios)
        {
            return beneficios * 0.5 / 100;
        }

        public override double hacienda()
        {
            return base.hacienda() + (base.hacienda()*0.5/100);
        }

    }
}
