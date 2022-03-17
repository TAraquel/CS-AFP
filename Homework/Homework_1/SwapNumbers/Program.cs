using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            bool firstInput = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter the second number:");
            bool secondInput = int.TryParse(Console.ReadLine(), out int secondNumber);

            Console.WriteLine("Before swapping:");
            Console.WriteLine($"First number : {firstNumber}");
            Console.WriteLine($"Second number : {secondNumber}");

            int holder = firstNumber;
            firstNumber = secondNumber;
            secondNumber = holder;

            Console.WriteLine("After swapping:");
            Console.WriteLine($"First number : {firstNumber}");
            Console.WriteLine($"Second number : {secondNumber}");
        }
    }
}
