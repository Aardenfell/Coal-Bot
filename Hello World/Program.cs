using System;
using System.Threading;

namespace Hello_World
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string name;
            string answer;
            int number;
            do
            {
                Console.WriteLine("Hello World!");
                Thread.Sleep(2000);
                Console.WriteLine("Oh.. Hello there.");
                Console.WriteLine("My name is [Coal]!");
                Thread.Sleep(2000);
                Console.WriteLine("What is you name?");
                name = Console.ReadLine();
                Thread.Sleep(2000);
                Console.WriteLine("Hello, " + name + "!");
                AskAgain:
                Console.WriteLine("Would you like to play a game? [Y/N]");
                answer = Console.ReadLine();
                if (answer == "N" || answer == "n")
                {
                    Console.WriteLine("Aw alright then, I guess I'll go then...");
                    Console.WriteLine("Bye bye");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    
                }
                if (answer == "Y" || answer == "y")
                {
                    Console.WriteLine("GREAT!");
                    break;
                }
                else if (answer != "Y" || answer != "y" || answer != "N" || answer != "n")
                {
                    Console.WriteLine("I'm sorry. I don't understand that");
                    Thread.Sleep(1000);
                    goto AskAgain;
                }
            } while ((answer == "Y") || (answer == "y"));
            PlayAgain:
            do
            {
                Console.WriteLine("Okay. Choose any number and I'll tell you if it's prime or not.");
                Thread.Sleep(1500);
                tryAgain:
                Console.WriteLine("Ready?");
                Thread.Sleep(1500);
                Console.WriteLine("GO!");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine()); // Still looking to catch invalid entry I.E: "-", "(", etc.
                }
                catch (Exception) // Catches when number is too high :)
                {
                    Console.WriteLine("Owwie. That number is too big");
                    Console.WriteLine("Can you try a smaller number please?");
                    Thread.Sleep(1000);
                    goto tryAgain;
                }
                
                if (IsPrime(number))
                {
                    Console.WriteLine("It is prime! YAAAAY!");
                    Thread.Sleep(1500);
                    again1:
                    Console.WriteLine("Wanna play again? :0");
                    Console.WriteLine("[Y/N]");
                    answer = Console.ReadLine();
                    if (answer == "N" || answer == "n")
                    {
                        Console.WriteLine("Aw alright then, I guess I'll go then...");
                        Console.WriteLine("Bye bye");
                        Thread.Sleep(2000);
                        Environment.Exit(0);

                    }
                    if (answer == "Y" || answer == "y")
                    {
                        Console.WriteLine("GREAT!");
                        goto PlayAgain;
                    }
                    else if (answer != "Y" || answer != "y" || answer != "N" || answer != "n")
                    {
                        Console.WriteLine("I'm sorry. I don't understand that");
                        Thread.Sleep(1000);
                        goto again1;
                    }
                }
                else
                {
                    Console.WriteLine("It is not prime. :( sad face ");
                    Thread.Sleep(1500);
                    again2:
                    Console.WriteLine("Wanna play again? :0");
                    Console.WriteLine("[Y/N]");
                    answer = Console.ReadLine();
                    if (answer == "N" || answer == "n")
                    {
                        Console.WriteLine("Aw alright then, I guess I'll go then...");
                        Console.WriteLine("Bye bye");
                        Thread.Sleep(2000);
                        Environment.Exit(0);

                    }
                    if (answer == "Y" || answer == "y")
                    {
                        Console.WriteLine("GREAT!");
                        goto PlayAgain;
                    }
                    else if (answer != "Y" || answer != "y" || answer != "N" || answer != "n")
                    {
                        Console.WriteLine("I'm sorry. I don't understand that");
                        Thread.Sleep(1000);
                        goto again2;
                    }
                }
            } while ((answer == "Y") || (answer == "y"));
        }
    }
}
