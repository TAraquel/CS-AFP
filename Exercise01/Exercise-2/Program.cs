using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            bool firstInput = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter the second number:");
            bool secondInput = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Enter the third number:");
            bool thirdInput = int.TryParse(Console.ReadLine(), out int thirdNumber);
            Console.WriteLine("Enter the forth number:");
            bool forthInput = int.TryParse(Console.ReadLine(), out int forthNumber);
            
            if(firstInput && secondInput && thirdInput && forthInput)
            {
                int averege = (firstNumber + secondNumber + thirdNumber + forthNumber) / 4;
                Console.WriteLine($"The average number of {firstNumber}, {secondNumber}, {thirdNumber} and {forthNumber} is: {averege}");
            }
            else
            {
                Console.WriteLine("Your input is not valid, please try again!");
            }

        }
    }
}
