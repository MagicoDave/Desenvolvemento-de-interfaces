using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ejercicio2.Aula;

namespace ejercicio2
{
    internal class Menu
    {

        //TODO: Hace falta una función para generar menus

        private Aula clase;
        private int seleccion;
        public string[] nombresAsignaturas = Enum.GetNames(typeof(Asignaturas));

        public Aula Clase
        {
            set => clase = value;
            get => clase;
        }

        public Menu (params string[] nombres)
        {
            Clase = new Aula(nombres);
        }

        public void Inicio()
        {

            int seleccion2;

            do
            {
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Calcular la media de notas de toda la clase");
                Console.WriteLine("2. Media de un alumno");
                Console.WriteLine("3. Media de una asignatura");
                Console.WriteLine("4. Ver notas de un alumno");
                Console.WriteLine("5. Ver notas de una asignatura");
                Console.WriteLine("6. Nota máxima y mínima de un alumno");
                Console.WriteLine("7. Ver la tabla completa");
                Console.WriteLine("8. Salir");

                PedirSeleccion(out seleccion, 8);

                switch (seleccion)
                {
                    case 1: //Media de la clase
                        Console.Clear();
                        Console.WriteLine("Media de notas de toda la clase: {0}", Clase.mediaNotas());
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2: //Media del alumno
                        Console.Clear();
                        seleccion2 = generarMenu(Clase.Alumnos);
                        if (seleccion2 != -1)
                        {
                            Console.WriteLine("La media del alumno {0} es {1}.", Clase.Alumnos[seleccion2], Clase.mediaAlumno(seleccion2));
                        }
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3: //Media de la asignatura
                        Console.Clear();
                        seleccion2 = generarMenu(nombresAsignaturas);
                        if (seleccion2 != -1)
                        {
                            Console.WriteLine("La media de la asignatura {0} es {1}.", nombresAsignaturas[seleccion2], Clase.mediaAsignatura(seleccion2));
                        }
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4: //Notas de un alumno
                        Console.Clear();
                        seleccion2 = generarMenu(Clase.Alumnos);
                        if (seleccion2 != -1)
                        {
                            tablaNotasAlumno(seleccion2);
                        }
                        Console.WriteLine("\n\nPulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5: //Notas asignatura
                        Console.Clear();
                        seleccion2 = generarMenu(nombresAsignaturas);
                        if (seleccion2 != -1)
                        {
                            tablaNotasAsignatura(seleccion2);
                        }
                        Console.WriteLine("\n\nPulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6: //Max/Min alumno
                        Console.Clear();
                        seleccion2 = generarMenu(Clase.Alumnos);
                        if (seleccion2 != -1)
                        {
                            int max, min;
                            Clase.alumnoMaxMin(seleccion2, out max, out min);
                            Console.WriteLine("La nota máxima del alumno {0} es {1} y la mínima es {2}",
                                Clase.Alumnos[seleccion2], max, min);
                        }
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7: //Tabla completa
                        Console.Clear();
                        tablaNotas();
                        Console.WriteLine("\n\nPulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8: //Salir
                        Console.WriteLine("El programa se cerrará.");
                        break;
                    default:
                        Console.WriteLine("Esto no debería ser posible, revisar código.");
                        break;
                }
            } while (seleccion !=8);
        }

        private void PedirSeleccion(out int seleccion, int maxRango)
        {
            bool bandera;

            do
            {
                bandera = true;
                if (!int.TryParse(Console.ReadLine(), out seleccion))
                {
                    Console.WriteLine("No se a podido convertir a entero. Inténtalo de nuevo.");
                    bandera = false;
                }
                else if (seleccion < 1 || seleccion > maxRango)
                {
                    Console.WriteLine("Valor fuera del rango. Inténtalo de nuevo.");
                    bandera = false;
                }
            } while (!bandera);

        }

        private int generarMenu(string[] opciones)
        {
            int contador = 1;
            int seleccion;

            //Dibujar menú
            foreach (string opcion in opciones)
            {
                Console.WriteLine("{0}. {1}", contador, opcion);
                contador++;
            }
            Console.WriteLine("{0}. Volver", contador);

            //Gestionar opciones
            do
            {
                Console.WriteLine("Introduzca una opción: ");
                if (!int.TryParse(Console.ReadLine(), out seleccion))
                {
                    Console.WriteLine("No se pudo convertir a entero. Intentar de nuevo");
                }
                else if (seleccion > opciones.Length + 1 || seleccion <= 0)
                {
                    Console.WriteLine("El valor elegido no está en el rango. Intentar de nuevo");
                }
                else if (seleccion <= opciones.Length)
                {
                    break;
                }
                else if (seleccion == opciones.Length + 1)
                {
                    Console.WriteLine("Volviendo al menú...");
                    return -1;
                }
            } while (seleccion != opciones.Length + 1);

            return seleccion - 1;

        }

        public void tablaNotas()
        {

            Console.Write("\n|{0,12}|", " ");
            foreach (string asig in nombresAsignaturas)
            {
                Console.Write("{0,12}|", asig);
            }

            for (int i = 0; i < Clase.Notas.GetLength(0); i++)
            {
                Console.Write("\n|{0,12}|", Clase.Alumnos[i]);
                for (int j = 0; j < Clase.Notas.GetLength(1); j++)
                {
                    Console.Write("{0,12}|", Clase.Notas[i, j]);
                }
            }
        }

        public void tablaNotasAlumno(int alumno)
        {
            Console.Write("\n|{0,12}|", " ");
            foreach (string asig in nombresAsignaturas)
            {
                Console.Write("{0,12}|", asig);
            }

            
            Console.Write("\n|{0,12}|", Clase.Alumnos[alumno]);
            for (int j = 0; j < Clase.Notas.GetLength(1); j++)
            {
                Console.Write("{0,12}|", Clase.Notas[alumno, j]);
            }
            
        }

        public void tablaNotasAsignatura(int asignatura)
        {
            Console.Write("\n|{0,12}|", " ");
            Console.Write("{0,12}|", nombresAsignaturas[asignatura]);

            for (int i = 0; i < Clase.Notas.GetLength(0); i++)
            {
                Console.Write("\n|{0,12}|", Clase.Alumnos[i]);
                Console.Write("{0,12}|", Clase.Notas[i, asignatura]);
            }
        }



    }
}
