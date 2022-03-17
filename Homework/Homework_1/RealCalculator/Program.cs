using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator you need: ( + | - | / | * )");
            char userOperator = char.Parse(Console.ReadLine());

            double endResult;

            if (userOperator == '+')
            {
                endResult = firstNumber + secondNumber;
                Console.WriteLine($"The addition of {firstNumber} and {secondNumber} is : {endResult}");
            }
            else if (userOperator == '-')
            {
                endResult = firstNumber - secondNumber;
                Console.WriteLine($"The subtraction of {firstNumber} and {secondNumber} is : {endResult}");
            }
            else if (userOperator == '/')
            {
                endResult = firstNumber / secondNumber;
                Console.WriteLine($"The devision of {firstNumber} and {secondNumber} is : {endResult}");
            }
            else if (userOperator == '*')
            {
                endResult = firstNumber * secondNumber;
                Console.WriteLine($"The multiplication of {firstNumber} and {secondNumber} is : {endResult}");
            }
            else
            {
                Console.WriteLine("You have entered a wrong input, please try again!");
            }
        }
    }
}
