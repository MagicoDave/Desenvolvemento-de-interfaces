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
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Media de notas de toda la clase: {0}", Clase.mediaNotas());
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Pulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Clase.tablaNotas();
                        Console.WriteLine("\n\nPulsa una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
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

        

    }
}
