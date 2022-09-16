using System;
using System.Numerics;

namespace ejercicio4
{
    internal class Program
    {

        static int pedirNumero()
        {
            Boolean error = true;
            int numero = 0;

            while (error)
            {
                try
                {
                    error = false;
                    String? aux = Console.ReadLine();
                    numero = int.Parse(aux);
                }
                catch (FormatException)
                {
                    Console.WriteLine("No se pudo convertir a entero\n Intentalo de nuevo\n");
                    error = true;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("No se puede dejar en blanco\n Intentalo de nuevo\n");
                    error = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("No me hagas fallar el programa Curro\n Intentalo de nuevo\n");
                    error = true;
                }
            }

            return numero;
        }

        static string resultadoPonderado()
        {
            Random generador = new Random();

            int resultado = generador.Next(0, 100);

            if (resultado <= 59)
            {
                return "1";
            } else if (resultado > 59 && resultado <= 84)
            {
                return "X";
            } else
            {
                return "2";
            }
        }


        static void pintaMenu(string[] opciones, int opcion)
        {
            string titulo = "MENU";

            Console.Clear();
            Console.WriteLine(titulo);
            for (int i = 0; i < opciones.Length; i++)
            {
                if (i == opcion) // Pinta la opción seleccionada en Video Inverso
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(opciones[i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        static void tirarDado()
        {
            Console.Clear();
            Console.WriteLine("Juego tirar dados\nElige el número de caras del dado");
            Boolean error = false;
            int carasDado = pedirNumero();
            Console.WriteLine("Apuesta por un número del dado: ");
            int apuesta = 0;
            while (apuesta < 1 || apuesta > carasDado)
            {
                apuesta = pedirNumero();
                if (apuesta < 1 || apuesta > carasDado)
                {
                    Console.Write("El valor elegido no está dentro de las caras del dado. Elige de nuevo\n");
                }
            }
            int[] tiradas = new int[10];
            int aciertos = 0;
            Random generador = new Random();
            Console.WriteLine("\nTiradas: \n");
            for (int i = 0; i < tiradas.Length; i++)
            {
                tiradas[i] = generador.Next(1, carasDado + 1);
                Console.Write(tiradas[i] + "\n");
            }
            foreach (int tirada in tiradas)
            {
                if (tirada == apuesta)
                {
                    aciertos++;
                }
            }
            Console.WriteLine("\nDe diez tiradas, tu apuesta ({0}) ha salido {1} vez/veces\n", apuesta, aciertos);
            Console.WriteLine("Pulsa cualquier tecla para continuar\n");
            Console.ReadKey();


        }

        static void adivinaNumero()
        {
            Console.Clear();

            Random generador = new Random();
            int numSecreto = generador.Next(1, 101);
            int intentos = 5;
            int jugador = 0;

            Console.WriteLine("Juego adivinar\nIntenta adivinar un número del 1 al 100 ({0}): ", numSecreto);
            do
            {
                jugador = pedirNumero();
                if (jugador < numSecreto)
                {
                    intentos--;
                    Console.WriteLine("El número secreto es mayor que el tuyo. Te quedan {0} intentos\n", intentos);
                } else if (jugador > numSecreto)
                {
                    intentos--;
                    Console.WriteLine("El número secreto es menor que el tuyo. Te quedan {0} intentos\n", intentos);
                } else
                {
                    Console.WriteLine("¡Acertaste! ¡Felicidades! \n");
                    break;
                }

                if (intentos == 0)
                {
                    Console.WriteLine("¡Perdiste! El número secreto era {0}\n", numSecreto);
                }
            } while (intentos > 0);
            Console.WriteLine("Pulsa cualquier tecla para continuar\n");
            Console.ReadKey();
        }

        static void quiniela()
        {
            Console.Clear();
            Console.WriteLine("Juego quiniela\nEstos son los resultados de su quiniela:\n");
            for (int i = 1; i <= 14; i++)
            {
                Console.WriteLine("Resultado {0}: {1}\n", i, resultadoPonderado());
            }
            Console.WriteLine("Pulsa cualquier tecla para continuar\n");
            Console.ReadKey();
        }

         
        static void Main(string[] args)
        {
            int opcion = 0;
            int seleccion = -1;

            string[] opciones = { "Tirar dado", "Adivina un número", "Quiniela", "Jugar a todo", "Salir" };
            Console.CursorVisible = false;
            pintaMenu(opciones, opcion);

            do
            {

                ConsoleKeyInfo tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        opcion = opcion < opciones.Length - 1 ? opcion + 1 : opcion;
                        break;
                    case ConsoleKey.UpArrow:
                        opcion = opcion > 0 ? opcion - 1 : opcion;
                        break;
                    case ConsoleKey.Spacebar:
                        seleccion = opcion;
                        string yesno = "n";
                        switch (seleccion)
                        {
                            case 3:
                            case 0:
                                tirarDado();
                                if (seleccion == 3)
                                {
                                    goto case 1;
                                }
                                do
                                {
                                    Console.Write("¿Quieres volver a jugar a este juego? [y/n]");
                                    yesno = Console.ReadLine();
                                    if (yesno == "y")
                                    {
                                        goto case 0;
                                    } else if (yesno == "n")
                                    {
                                        break;
                                    }
                                } while (yesno != "y" && yesno != "n");
                                break;
                            case 1:
                                adivinaNumero();
                                if (seleccion == 3)
                                {
                                    goto case 2;
                                }
                                do
                                {
                                    Console.Write("¿Quieres volver a jugar a este juego? [y/n]");
                                    yesno = Console.ReadLine();
                                    if (yesno == "y")
                                    {
                                        goto case 1;
                                    }
                                    else if (yesno == "n")
                                    {
                                        break;
                                    }
                                } while (yesno != "y" && yesno != "n");
                                break;
                            case 2:
                                quiniela();
                                
                                if (seleccion == 3)
                                {
                                    do
                                    {
                                        Console.Write("¿Quieres volver a jugar a todos los juegos? [y/n]");
                                        yesno = Console.ReadLine();
                                        if (yesno == "y")
                                        {
                                            goto case 0;
                                        }
                                        else if (yesno == "n")
                                        {
                                            break;
                                        }
                                    } while (yesno != "y" && yesno != "n");
                                } else
                                {
                                    do
                                    {
                                        Console.Write("¿Quieres volver a jugar a este juego? [y/n]");
                                        yesno = Console.ReadLine();
                                        if (yesno == "y")
                                        {
                                            goto case 2;
                                        }
                                        else if (yesno == "n")
                                        {
                                            break;
                                        }
                                    } while (yesno != "y" && yesno != "n");
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        seleccion = opciones.Length - 1;
                        break;
                }
                pintaMenu(opciones, opcion);
                Console.WriteLine("Opción elegida: {0}", seleccion);

            } while (seleccion != opciones.Length - 1); //Dejar la opción de salir siempre al final
            

        }
    }
}