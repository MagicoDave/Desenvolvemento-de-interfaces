using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    internal class Game
    {

        static readonly object l = new object();

        static public bool flag;
        static public bool pause;
        int score;

        public static Display display = new Display(new int[] { 20, 6 }, l);
        Player player1 = new Player("Player 1", new int[] { 5, 5 }, true, l, display);
        Player player2 = new Player("Player 2", new int[] { 30, 5 }, false, l, display);


        public void start()
        {
            player1.thread.Start();
            player2.thread.Start();
            display.thread.Start();

            player1.thread.Join();
            player2.thread.Join();
            display.thread.Join();

            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
