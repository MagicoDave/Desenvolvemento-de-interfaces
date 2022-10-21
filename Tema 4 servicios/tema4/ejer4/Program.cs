namespace ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TirarCuerda juego = new TirarCuerda();
            juego.jugar();

            if (juego.Cuerda >= 1000)
            {
                Console.WriteLine("Gana el primer hilo");
            } else
            {
                Console.WriteLine("Gana el segundo hilo");
            }
        }
    }
}