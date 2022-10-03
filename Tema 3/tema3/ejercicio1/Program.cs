using System.Collections;

namespace ejercicio1
{
    internal class Program
    {
        //TODO: Hay que tener en cuenta si la base de datos está vacía porque si no puede entrar en bucle infinito
        static void Main(string[] args)
        {
            Dictionary<string, int> ordenadores = new Dictionary<string, int>();
            ordenadores.Add("192.168.20.10", 8);
            ordenadores.Add("192.168.20.11", 8);
            ordenadores.Add("192.168.20.12", 16);
            ordenadores.Add("192.168.20.13", 32);

            int opcion = 0;
            int seleccion = -1;
            string[] opciones = { "Introducir nuevo ordenador", "Eliminar dato por clave", "Mostrar colección", "Mostrar ordenador", "Salir" };
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
                        string ip;
                        int ram;
                        bool error;
                        switch (seleccion)
                        {
                            case 0: //Introducir nuevo ordenador
                                Console.Clear();
                                Console.WriteLine("Introduce una IP para el nuevo ordenador: ");
                                do
                                {
                                    error = false;
                                    ip = pedirIp();
                                    if (comprobarIp(ip, ordenadores))
                                    {
                                        Console.WriteLine("La IP ya existe. Introduzca una IP diferente: ");
                                        error = true;
                                    }
                                } while (error);
                                Console.WriteLine("Introduce una cantidad de RAM para el nuevo ordenador: ");
                                ram = pedirRam();
                                try
                                {
                                    ordenadores.Add(ip, ram);
                                    Console.WriteLine("Ha añadido un nuevo ordenador con IP {0} y RAM {1}.\nPresione una tecla para continuar", ip, ordenadores[ip]);
                                    Console.ReadKey();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("No se ha podido añadir el ordenador. Ha ocurrido un error:\n\t{0}\nPulsa una tecla para continuar.", e.ToString);
                                    Console.ReadKey();
                                }
                                break;
                            case 1: //Borrar ordenador
                                Console.Clear();
                                if (ordenadores.Count == 0)
                                {
                                    Console.WriteLine("No hay ordenadores que borrar. Introduzca un nuevo ordenador primero.");
                                    Console.WriteLine("Pulse una tecla para continuar");
                                    Console.ReadKey();
                                } else
                                {
                                    Console.WriteLine("Introduce la IP del ordenador que quieres borrar: ");
                                    do
                                    {
                                        error = false;
                                        ip = pedirIp();
                                        if (!comprobarIp(ip, ordenadores))
                                        {
                                            Console.WriteLine("La IP no existe. Introduzca una IP diferente: ");
                                            error = true;
                                        }
                                    } while (error);
                                    try
                                    {
                                        ordenadores.Remove(ip);
                                        Console.WriteLine("Ha eliminado el ordenador con IP {0}.\nPresione una tecla para continuar", ip);
                                        Console.ReadKey();
                                    }
                                    catch (ArgumentNullException)
                                    {
                                        Console.WriteLine("De alguna misteriosa manera, hemos conseguido un ArgumentNullException a pesar del control de excepciones. Buen trabajo" +
                                            "\nPulsa una tecla para continuar");
                                        Console.ReadKey();
                                    }
                                }
                                break;
                            case 2: //Mostrar colección
                                Console.Clear();
                                if (ordenadores.Count == 0)
                                {
                                    Console.WriteLine("No hay ordenadores que mostrar. Introduzca un nuevo ordenador primero.");
                                }
                                else
                                {
                                    foreach (KeyValuePair<string, int> de in ordenadores)
                                    {
                                        Console.WriteLine("Ordenador (IP): {0}\n\tRAM: {1}GB", de.Key, de.Value);
                                    }
                                }   
                                Console.WriteLine("Pulse una tecla para continuar");
                                Console.ReadKey();
                                break;
                            case 3: //Mostrar ordenador
                                Console.Clear();
                                if (ordenadores.Count == 0)
                                {
                                    Console.WriteLine("No hay ordenadores que mostrar. Introduzca un nuevo ordenador primero.");
                                    Console.WriteLine("Pulse una tecla para continuar");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Introduce la IP del ordenador a mostrar: ");
                                    do
                                    {
                                        error = false;
                                        ip = pedirIp();
                                        if (!comprobarIp(ip, ordenadores))
                                        {
                                            Console.WriteLine("La IP no existe en la colección. Introduzca una IP diferente: ");
                                            error = true;
                                        }
                                    } while (error);
                                    Console.WriteLine("Ordenador (IP): {0}\n\tRAM: {1}GB", ip, ordenadores[ip]);
                                    Console.WriteLine("Pulse una tecla para continuar");
                                    Console.ReadKey();
                                }
                                break;
                            default: //Salir
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

        static string pedirIp()
        {

            string cadena = "default";
            string[] aux;
            int num;
            bool bandera;
            bool error;

            do
            {
                try
                {
                    error = false;
                    cadena = Console.ReadLine();
                    if (cadena == null || cadena.Trim() == "")
                    {
                        Console.WriteLine("No se puede dejar este campo vacio. Intentelo de nuevo.");
                        error = true;
                    } else
                    {
                        aux = cadena.Split('.');
                        if (aux.Length != 4)
                        {
                            Console.WriteLine("Formato no válido, tienen que ser cuatro números separados por puntos. Intentelo de nuevo.");
                            error = true;
                        } else
                        {
                            for (int i = 0; i < aux.Length; i++)
                            {
                                bandera = int.TryParse(aux[i], out num);
                                if (!bandera)
                                {
                                    Console.WriteLine("Formato no válido, no se pudo convertir a entero alguna de las partes separadas por punto. Intentelo de nuevo.");
                                    error = true;
                                } else if (num < 0 || num > 255)
                                {
                                    Console.WriteLine("Los valores deben estar entre 0 y 255. Intentelo de nuevo.");
                                    error = true;
                                }
                            }
                        }
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error:\n\t{0}", e.ToString);
                    error = true;
                }
            } while (error);

            return cadena;
        }

        static bool comprobarIp(string ip, Dictionary<string, int> ordenadores)
        {

            if (ordenadores.ContainsKey(ip))
            {
                return true;
            }

            return false;
        }

        static int pedirRam()
        {
            int i;
            bool aux;
            bool error;

            do
            {
                error = false;
                aux = int.TryParse(Console.ReadLine(), out i);
                if (!aux)
                {
                    Console.WriteLine("No se ha podido convertir a entero. Intentelo de nuevo: ");
                    error = true;
                }
                if (i <= 0)
                {
                    Console.WriteLine("La memoria tiene que ser superior a 0. Intentelo de nuevo: ");
                    error = true;
                }

            } while (error);

            return i;
        }
    }
}