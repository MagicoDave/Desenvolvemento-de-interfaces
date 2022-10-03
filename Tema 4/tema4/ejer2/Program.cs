using System.Runtime.Serialization.Formatters;

namespace ejer2
{
    internal class Program
    {
        public delegate void MyDelegate();

        public static void MenuGenerator(string[] opciones, MyDelegate[] delegados)
        {
            int contador = 1;
            bool control = true;
            foreach (string opcion in opciones)
            {
                Console.WriteLine("{0}. {1}", contador, opcion);
                contador++;
            }
            Console.WriteLine("{0}. Salir", contador);
            do
            {
                Console.WriteLine("Introduzca una opción: ");
                int opcion;
                if (control != int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("No se pudo convertir a entero. Intentar de nuevo");
                } else if (control != opcion <= opciones.Length && opcion > 0)
                {
                    Console.WriteLine("El valor elegido no está en el rango. Intentar de nuevo");
                } else
                {
                    delegados[opcion - 1].Invoke();
                    //TODO Control de excepciones y si se creo correctamente el menú
                }
            } while (!control);
        }

        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }

        static void Main(string[] args)
        {
            MenuGenerator(new string[] { "Op1", "Op2", "Op3" },
                new MyDelegate[] { f1, f2, f3 });
            Console.ReadKey();
        }
    }
}