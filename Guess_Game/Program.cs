using System;

namespace Guess_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumb = new Random();
            int y = randomNumb.Next(0, 1000);
             
            
            while (true)
            {
                Console.ResetColor();
                Console.Write("Guess a number between 0-1000: ");
                int x = int.Parse(Console.ReadLine());
                if (x == y)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(x);
                    Console.WriteLine("That's right!");
                }
                else if (x <= y)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" >  {x} ");
                    Console.WriteLine("Let's do it one more time!");
                }
                else if (x >= y)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" < {x} ");
                    Console.WriteLine("Let's do it one more time!");
                }
                Console.ReadKey();
            }
           
        }
    }
}
