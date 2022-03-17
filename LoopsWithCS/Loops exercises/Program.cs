using System;

namespace Loops_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 01
                Console.WriteLine("Exercise 01");
                Console.WriteLine("Enter a number:");
                bool success = int.TryParse(Console.ReadLine(), out int counter);
                if (success)
                {
                    for(int i = 1; i<= 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Enter another number:");
                    int anotherCounter = int.Parse(Console.ReadLine());
                    for (int i = anotherCounter; i != 0; i--)
                    {
                        Console.WriteLine(i);
                }
            }
            #endregion

            #region Exercise 02

            Console.WriteLine("Exercise 02");
            Console.WriteLine("Input a number:");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 2; i <= userInput; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Input a second number:");
            int userInput2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= userInput2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            #region Exercise 03

            Console.WriteLine("Exercise 03");
            Console.WriteLine("Enter a number:");
            int maxCounter = int.Parse(Console.ReadLine());
            for (int i = 1; i <= maxCounter; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                if (i == 100)
                {
                    Console.WriteLine("You have reached the limit");
                    break;
                }
                Console.WriteLine(i);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
