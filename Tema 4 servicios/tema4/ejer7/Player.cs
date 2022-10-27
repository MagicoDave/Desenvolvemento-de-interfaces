using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    internal class Player
    {
        private int[] position = new int[2];
        private int n;
        static private int score;
        private bool add;
        private bool firstTime = true;
        private string name;
        private Random generator = new Random();
        public Thread thread;
        public Display display;

        static public bool flag = true;
        object l = new object();

        private void play()
        {
            //Draw name
            lock (l)
            {
                Console.SetCursorPosition(Position[0], Position[1]);
                Console.Write(Name);
                showScore();
            }

            //Draw random numbers from 1 to 10 under the name
            while (flag)
            {
                lock (l)
                {
                    if (flag)
                    {
                        N = generator.Next(1, 11);
                        Console.SetCursorPosition(Position[0], Position[1] + 1);
                        Console.Write(string.Format("{0,2}", N));
                        if (N == 5 || N == 7)
                        {
                            if (add)
                            {
                                if (display.pause)
                                {
                                    score += 5;
                                    showScore();
                                }
                                else
                                {
                                    score++;
                                    showScore();
                                    display.pause = true;
                                }
                            }
                            else
                            {
                                if (display.pause)
                                {
                                    score--;
                                    showScore();
                                    display.pause = false;
                                    Monitor.Pulse(l);
                                }
                                else
                                {
                                    if (firstTime)
                                    {
                                        firstTime = false;
                                    }
                                    else
                                    {
                                        score -= 5;
                                        showScore();
                                    }
                                }
                            }
                        }
                        if (score >= 20 || score <= -20)
                        {
                            Console.SetCursorPosition(Position[0], Position[1]);
                            Console.Write(Name + " wins!");
                            Monitor.Pulse(l);
                            display.flag = false;
                            flag = false;
                        }
                    }
                }
                Thread.Sleep(100 * N);
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

        public Player(string name, int[] position, bool add, object l, Display display)
        {
            Name = name;
            Position = position;
            this.add = add;
            score = 0;
            this.display = display;
            this.l = l;
            thread = new Thread(play);

        }

        private void showScore()
        {
            Console.SetCursorPosition(16,10);
            Console.Write("Score: {0,2}", score);
        }

        


    }
}
