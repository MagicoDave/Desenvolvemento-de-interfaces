using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    class Aula
    {
        private int[,] notas;
        private string[] alumnos;
        public enum Asignaturas
        {
            Pociones,
            Quidditch,
            Criaturas,
            ArtesOscuras
        }

        public int[,] Notas
        {
            set => notas = value;
            get => notas;
        }

        public string[] Alumnos
        {
            set => alumnos = value;
            get => alumnos;
        }


        public Aula(string[] alumnos)
        {
            Random generador = new Random();

            Alumnos = alumnos;
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Alumnos[i] = Alumnos[i].Trim().ToUpper();
            }

            Notas = new int[Alumnos.Length, 4];
            for (int i = 0; i < Notas.GetLength(0); i++)
            {
                for (int j = 0; j < Notas.GetLength(1); j++)
                {
                    Notas[i, j] = generador.Next(0, 11);
                }
            }
        }

        public Aula(string alumnos)
        {
            Random generador = new Random();

            Alumnos = alumnos.Split(',');
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Alumnos[i] = Alumnos[i].Trim().ToUpper();
            }

            Notas = new int[Alumnos.Length, 4];
            for (int i = 0; i < Notas.GetLength(0); i++)
            {
                for (int j = 0; j < Notas.GetLength(1); j++)
                {
                    Notas[i, j] = generador.Next(0, 11);
                }
            }
        }

        public int this[int fila, int columna]
        {
            set
            {
                Notas[fila, columna] = value;
            }
            get
            {
                return Notas[fila, columna];
            }
        }

        public double mediaNotas()
        {
            double aux = 0;
            for (int i = 0; i < Notas.GetLength(0); i++)
            {
                for (int j = 0; j < Notas.GetLength(1); j++)
                {
                    aux += Notas[i, j];
                }
            }

            return aux / Notas.Length;// (Notas.GetLength(0) * Notas.GetLength(1));
        }

        public double mediaAlumno(int indiceAlumno)
        {
            double aux = 0;

            for (int i = 0; i < Notas.GetLength(1); i++)
            {
                aux += Notas[indiceAlumno, i];
            }

            return aux / Notas.GetLength(1);

        }

        public double mediaAsignatura(int indiceAsignaturas)
        {
            double aux = 0;

            for (int i = 0; i < Notas.GetLength(0); i++)
            {
                aux += Notas[i, indiceAsignaturas];
            }

            return aux / Notas.GetLength(0);
        }

        public void alumnoMaxMin(int indiceAlumno, out int max, out int min)
        {
            min = 10;
            max = 0;
            for (int i = 0; i < Notas.GetLength(1); i++)
            {
                if (Notas[indiceAlumno, i] < min)
                {
                    min = Notas[indiceAlumno, i];
                }

                if (Notas[indiceAlumno, i] > max)
                {
                    max = Notas[indiceAlumno, i];
                }
            }
        }


    }
}

