using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Aula
    {
        public static int[,] notas;
        public string[] alumnos;
        enum Asignaturas
        {
            Pociones,
            Quidditch,
            Criaturas,
            ArtesOscuras
        }

        public Aula(string[] alumnos)
        {
            this.alumnos = new string[alumnos.Length];
            for (int i = 0; i < alumnos.Length; i++)
            {
                this.alumnos[i] = alumnos[i].Trim().ToUpper();
            }
            notas = new int[this.alumnos.Length,4];
        }

        public Aula(string alumnos)
        {
            this.alumnos = alumnos.Split(',');
            for (int i = 0; i < this.alumnos.Length; i++)
            {
                this.alumnos[i] = this.alumnos[i].Trim().ToUpper();
            }
            notas = new int[this.alumnos.Length,4];
        }

        public int this[int fila, int columna]
        {
            set
            {
                notas[fila, columna] = value; 
            }
            get
            {
                return notas[fila, columna];
            }
        }

        static double mediaNotas()
        {
            double aux = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    aux += notas[i, j];
                }
            }

            return aux / (notas.GetLength(0) * notas.GetLength(1));
        }

        static double mediaAlumno(int indiceAlumno)
        {
            double aux = 0;

            for (int i = 0; i < notas.GetLength(1); i++)
            {
                aux += notas[indiceAlumno, i];
            }

            return aux/notas.GetLength(1);

        }

        static double mediaAsignatura(int indiceAsignaturas)
        {
            double aux = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                aux += notas[i, indiceAsignaturas];
            }

            return aux / notas.GetLength(0);
        }

        static void alumnoMaxMin (int indiceAlumno, out int max, out int min)
        {
            min = 10;
            max = 0;
            for (int i = 0; i < notas.GetLength(1); i++)
            {
                if (notas[indiceAlumno, i] < min)
                {
                    min = notas[indiceAlumno, i];
                }

                if (notas[indiceAlumno, i] > max)
                {
                    max = notas[indiceAlumno, i];
                }
            }
        }

        static void tablaNotas()
        {
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {

                }
            }
        }
    }
}
