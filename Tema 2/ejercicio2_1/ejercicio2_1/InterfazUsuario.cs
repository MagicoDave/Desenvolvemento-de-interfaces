using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2_1
{
    internal class InterfazUsuario
    {
        public void Inicio()
        {
            int opcion = 0;
            int seleccion = -1;
            string[] opciones = { "Insertar nueva persona", "Eliminar personas", "Visualizar plantilla", "Visualizar persona", "Salir" };
            Console.CursorVisible = false;
            pintaMenu(opciones, opcion);
            do
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        opcion = opcion < opciones.Length - 1 ? opcion + 1 : opcion;
                        break;
                    case ConsoleKey.UpArrow:
                        opcion = opcion > 0 ? opcion - 1 : opcion;
                        break;
                    case ConsoleKey.Spacebar:
                        seleccion = opcion;
                        switch (seleccion)
                        {
                            case 0:
                                Console.Clear();
                                Insertar();
                                Console.WriteLine("Pulse cualquier tecla para continuar");
                                Console.ReadKey();
                                break;
                            case 1:
                                Console.Clear();

                                Console.WriteLine("Pulse cualquier tecla para continuar");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Pulse cualquier tecla para continuar");
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Pulse cualquier tecla para continuar");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Pulse cualquier tecla para continuar");
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        seleccion = opciones.Length - 1;
                        break;

                }
                pintaMenu(opciones, opcion);
                Console.WriteLine("Opción elegida: {0}", seleccion);

            } while (seleccion != opciones.Length - 1); // Última opción Salir
        }

        static void pintaMenu(string[] opciones, int opcion)
        {
            string titulo = "MENU";

            Console.Clear();
            Console.WriteLine(titulo);
            for (int i = 0; i < opciones.Length; i++)
            {
                if (i == opcion) // Pinta la opción seleccionada en Video Inverso
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(opciones[i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        static void Insertar()
        {
            Console.Clear();
            Console.WriteLine("¿Desea introducir un nuevo directivo o empleado?");
            Console.WriteLine("1. Directivo\n2. Empleado\n3. Volver");
            int opcion;
            bool bandera = true;
            do
            {
                bandera = int.TryParse(Console.ReadLine(), out opcion);
                if (bandera)
                {
                    if (bandera != opcion > 3 || opcion < 1)
                    {
                        Console.WriteLine("Parámetro fuera de rango, inténtelo de nuevo");
                        bandera = false;
                    }
                    else
                    {
                        switch (opcion)
                        {
                            case 1:
                                Directivo directivo = new Directivo();
                                directivo.introducirDatos();
                                break;
                            case 2:
                                Empleado empleado = new Empleado();
                                empleado.introducirDatos();
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se ha podido convertir a entero, inténtelo de nuevo");
                }
            } while (!bandera);

        }

        static void Eliminar()
        {
            int min, max;
            bool bandera;

            Console.Clear();
            Console.WriteLine("Introduzca posición a partir de la cual se hará la eliminación: ");
            do
            {
                bandera = int.TryParse(Console.ReadLine(), out min);
                if (!bandera)
                {
                    Console.WriteLine("No se ha podido convertir a entero, inténtelo de nuevo");
                }
            } while (!bandera);
            Console.WriteLine("Introduzca posición hasta la cual se hará la eliminación: ");
            do
            {
                bandera = int.TryParse(Console.ReadLine(), out max);
                if (!bandera)
                {
                    Console.WriteLine("No se ha podido convertir a entero, inténtelo de nuevo");
                }
            } while (!bandera);
        }
    }


}
