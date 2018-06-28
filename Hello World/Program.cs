using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

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
                Console.WriteLine("Would you like to play a game? [Y/N]");
                answer = Console.ReadLine();
                if (answer == "N")
                {
                    Console.WriteLine("Aw alright then, I guess I'll go then...");
                    Console.WriteLine("Bye bye");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    
                }
                else if (answer == "Y")
                {
                    Console.WriteLine("GREAT!");
                    break;
                }
                
            } while ((answer == "Y") || (answer == "y"));
            PlayAgain:
            do
            {
                Console.WriteLine("Okay. Choose any number and I'll tell you if it's prime or not.");
                Thread.Sleep(1500);
                Console.WriteLine("Ready?");
                Thread.Sleep(1500);
                Console.WriteLine("GO!");
                number = Convert.ToInt32(Console.ReadLine());
                if (IsPrime(number))
                {
                    Console.WriteLine("It is prime! YAAAAY!");
                    Thread.Sleep(1500);
                    Console.WriteLine("Wanna play again? :0");
                    Console.WriteLine("[Y/N]");
                    answer = Console.ReadLine();
                    if (answer == "N")
                    {
                        Console.WriteLine("Aw alright then, I guess I'll go then...");
                        Console.WriteLine("Bye bye");
                        Thread.Sleep(2000);
                        Environment.Exit(0);

                    }
                    else if (answer == "Y")
                    {
                        Console.WriteLine("GREAT!");
                        goto PlayAgain;
                    }
                }
                else
                {
                    Console.WriteLine("It is not prime. :( sad face ");
                    Thread.Sleep(1500);
                    Console.WriteLine("Wanna play again? :0");
                    Console.WriteLine("[Y/N]");
                    answer = Console.ReadLine();
                    if (answer == "N")
                    {
                        Console.WriteLine("Aw alright then, I guess I'll go then...");
                        Console.WriteLine("Bye bye");
                        Thread.Sleep(2000);
                        Environment.Exit(0);

                    }
                    else if (answer == "Y")
                    {
                        Console.WriteLine("GREAT!");
                        goto PlayAgain;
                    }
                }
            } while ((answer == "Y") || (answer == "y"));
        }
    }
}
