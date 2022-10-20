using System.Runtime.Serialization.Formatters;

namespace ejer2
{
    internal class Program
    {
        public delegate void MyDelegate();

        public static bool MenuGenerator(string[] opciones, MyDelegate[] delegados)
        {
            int contador = 1;
            int seleccion;

            //Control de parámetros
            if (opciones == null || delegados == null || opciones.Length != delegados.Length)
            {
                return false;
            }

            //Dibujar menú
            foreach (string opcion in opciones)
            {
                Console.WriteLine("{0}. {1}", contador, opcion);
                contador++;
            }
            Console.WriteLine("{0}. Salir", contador);

            //Gestionar opciones
            do
            {
                Console.WriteLine("Introduzca una opción: ");
                if (!int.TryParse(Console.ReadLine(), out seleccion))
                {
                    Console.WriteLine("No se pudo convertir a entero. Intentar de nuevo");
                } else if (seleccion > opciones.Length +1 || seleccion <= 0)
                {
                    Console.WriteLine("El valor elegido no está en el rango. Intentar de nuevo");
                } else if (seleccion <= opciones.Length)
                {
                    delegados[seleccion - 1].Invoke();
                } else if (seleccion == opciones.Length +1)
                {
                    Console.WriteLine("El programa se cerrará");
                }
            } while (seleccion != opciones.Length +1);

            return true;
        }

        //static void f1()
        //{
        //    Console.WriteLine("A");
        //}
        //static void f2()
        //{
        //    Console.WriteLine("B");
        //}
        //static void f3()
        //{
        //    Console.WriteLine("C");
        //}

        static void Main(string[] args)
        {
            MenuGenerator(new string[] { "Op1", "Op2", "Op3","op4"},
                new MyDelegate[] { () => {Console.WriteLine("A"); }, 
                    () => { Console.WriteLine("B"); }, 
                    () => { Console.WriteLine("C"); } ,
                 () => { Console.WriteLine("D"); }});
            Console.ReadKey();
        }
    }
}