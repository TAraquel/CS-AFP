using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6];
            int[] evenNumbersArray = new int[6];
            int sumOfEvenNumbers = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"Enter integer number {i+1}");
                intArray[i] = int.Parse(Console.ReadLine());
                if(intArray[i] % 2 == 0)
                {
                    evenNumbersArray[i] = intArray[i];
                }
            }

            foreach(int num in evenNumbersArray)
            {
                sumOfEvenNumbers += num;
            }

            Console.WriteLine($"The sum of all the even numbers in the array is: {sumOfEvenNumbers}");
        }
    }
}
