namespace ejercicio2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directivo jefe = new Directivo("Insufferable", "Asshole", 50, "44445555", "Ventas", 18);
            Empleado currito = new Empleado("Dave", "Casal", 30, "77461003", 1000, "644888618");
            EmpleadoEspecial hijoJefe = new EmpleadoEspecial("Slighly-Less-Insufferable", "Asshole", 22, "55554444", 2000, "60066006600");

            int opcion = 0;
            int seleccion = -1;
            string[] opciones = { "Visualizar directivo", "Visualizar empleado", "Visualizar empleado especial", "Salir" };
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
                                jefe.mostrarDatos();
                                beneficios(jefe);
                                Console.WriteLine("Parte de hacienda: {0}", jefe.hacienda());
                                Console.WriteLine("Pulse cualquier tecla para continuar");
                                Console.ReadKey();
                                break;
                            case 1:
                                Console.Clear();
                                currito.mostrarDatos();
                                Console.WriteLine("Pulse cualquier tecla para continuar");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                hijoJefe.mostrarDatos();
                                beneficios(hijoJefe);
                                Console.WriteLine("Parte de hacienda: {0}", hijoJefe.hacienda());
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

        static void beneficios(IPastaGansa dineros)
        {
            double beneficios;
            bool aux;

            do
            {
                Console.WriteLine("Introduce los beneficios de la empresa:");
                aux = double.TryParse(Console.ReadLine(), out beneficios);
                if (!aux)
                {
                    Console.WriteLine("Te he pedido beneficios, no que aporrees el teclado. Intentalo de nuevo por favor.");
                }
            } while (!aux);
            Console.WriteLine("Beneficios: {0}", dineros.ganarPasta(beneficios));
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
    }

}