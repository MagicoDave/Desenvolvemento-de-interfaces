
namespace ejer1

{
    internal class Program
    {
        //public static void view(int grade)
        //{
        //    Console.ForegroundColor = grade >= 5 ? ConsoleColor.Green : ConsoleColor.Red;
        //    Console.WriteLine($"Student grade: {grade,3}.");
        //    Console.ResetColor();
        //}
        //public static bool pass(int num)
        //{
        //    return num >= 5;
        //}

        static void Main(string[] args)
        {

            int[] v = { 2, 2, 6, 7, 1, 10, 3 };
            Array.ForEach(v, grade =>
            {
                Console.ForegroundColor = grade >= 5 ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine($"Student grade: {grade,3}.");
                Console.ResetColor();
            });
            int res = Array.FindIndex(v, pass => pass >= 5);


            // Exist
            Console.WriteLine($"The first passing student is number {res + 1} in the list.");
            res = Array.FindLastIndex(v, pass => pass >= 5);
            Console.WriteLine($"The last passing student is number {res + 1} in the list");
            Console.WriteLine("Inverse of every grade: ");
            Array.ForEach(v, invert =>
            {
                double aux = 1.0 / invert;
                Console.WriteLine("Student grade: {0:N2}.", aux);
            });
            Console.ReadKey();
        }
    }
}