namespace ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey respuesta = ConsoleKey.S;
            Caballo[] participantes = new Caballo[5];

            do
            {
                participantes[0] = new Caballo(new int[] { 0, 3 }, "Marcelo");
                participantes[1] = new Caballo(new int[] { 0, 5 }, "Spirit");
                participantes[2] = new Caballo(new int[] { 0, 7 }, "Ricardo");
                participantes[3] = new Caballo(new int[] { 0, 9 }, "Sardinilla");
                participantes[4] = new Caballo(new int[] { 0, 11 }, "Sombragris");

                foreach (Caballo caballo in participantes)
                {
                    Console.SetCursorPosition(caballo.Posicion[0], caballo.Posicion[1]);
                    Console.Write(String.Format("{0,15}", caballo.Nombre + ":"));
                    caballo.Posicion[0] += 16;
                }

                for (int i = 0; i < participantes.Length; i++)
                {
                    participantes[i].thread.Start();
                }

                for (int i = 0; i < participantes.Length; i++)
                {
                    participantes[i].thread.Join();
                }
 
                do
                {
                    Console.SetCursorPosition(0, 14);
                    Console.Write("Desea repetir la carrera? [s/n] ");
                    respuesta = Console.ReadKey().Key;
                    if (respuesta != ConsoleKey.Enter)
                    {
                        Console.WriteLine();
                    }
                    if (respuesta == ConsoleKey.S)
                    {
                        Console.Clear();
                    }
                } while (respuesta != ConsoleKey.S && respuesta != ConsoleKey.N);

            } while (respuesta != ConsoleKey.N);

        }
    }
}