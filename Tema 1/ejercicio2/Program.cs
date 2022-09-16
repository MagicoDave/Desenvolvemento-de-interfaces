#define FRASE

using System;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String? frase1;
            String? frase2;

            Console.WriteLine("Por favor, introduzca la frase 1: ");
            frase1 = Console.ReadLine();
            Console.WriteLine("Por favor, introduzca la frase 2: ");
            frase2 = Console.ReadLine();

#if FRASE
            Console.WriteLine("{0}\t\t{1}\n{0}\n{1}", frase1, frase2);
#else
            Console.WriteLine("\"{0}\" \\{1}\\", frase1, frase2);
#endif
        }
    }
}