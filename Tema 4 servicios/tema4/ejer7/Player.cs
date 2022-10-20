using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    internal class Player
    {
        private int[] position = new int[2];
        private int n;
        private string name;
        private Random generator = new Random();
        Thread thread;
        static public bool flag;

        static readonly object l = new object();

        private void play()
        {
            //Draw name
            lock (l)
            {
                Console.SetCursorPosition(Position[0], Position[1]);
                Console.Write(Name);
            }

            //Draw random numbers from 1 to 10 under the name
            while (flag)
            {
                lock (l)
                {
                    N = generator.Next(1, 11);
                    Console.SetCursorPosition(Position[0], Position[1] + 1);
                    Console.Write(string.Format("{0,2}", N));
                    Thread.Sleep(100 * N);
                }
            }
        }

        public int[] Position
        {
            set => position = value;
            get => position;
        }

        public int N
        {
            set => n = value;
            get => n;
        }

        public string Name
        {
            set => name = value;
            get => name;
        }

        public Player(string name, int[] position)
        {
            Name = name;
            Position = position;
            flag = true;
            thread = new Thread(play);
            thread.Start();

        }

        


    }
}
