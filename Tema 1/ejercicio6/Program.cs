namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            double resultado = 0;
            factorial(num, ref resultado);
            Console.WriteLine("El factorial de {0} es {1}. Pulsa una tecla para continuar", num, resultado);
            Console.ReadKey();
            Console.Clear();

            dibujitos(6);
            Console.ReadKey();
        }

        static bool factorial(double num, ref double factorial)
        {
            if (num == 0)
            {
                factorial = 1;
                return true;
            }
            if (num < 0 || num > 10)
            {
                return false;
            }
            else
            {
                factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                return true;
            }
        }

        static void dibujitos(int num)
        {
            Random generator = new Random();
            for (int i = 0; i < num; i++)
            {
                Console.SetCursorPosition(generator.Next(1, 21), generator.Next(1, 11));
                Console.Write("*");
            }
        }

        static void dibujitos()
        {
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(generator.Next(1, 21), generator.Next(1, 11));
                Console.Write("*");
            }
        }


    }
}
