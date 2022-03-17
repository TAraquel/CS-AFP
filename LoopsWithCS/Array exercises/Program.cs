using System;

namespace Array_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 01
            Console.WriteLine("===Exercise 01===");

            string[] stringArray = { "Ajde", "zdravo", "jas", "sum", "Gorjan" };
            double[] decimalNumbers = { 22.65, 245.122, 241.111, 87.99999 };
            int[] integerArray = { 2, 22, 42, 444, 212 };
            char[] charactersArray = { 'A', '@', '&', '+', '2' };
            bool[] booleansArray = { true, false, false, true, true };
            int[][] arraysOfInts = { new int[] { 44, 67 }, new int[] { 8, 91 }, new int[] { 82, 99 }, new int[] { 22, 65 }, new int[] { 2412, 2245 } };
            int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            foreach (string word in stringArray)
            {
                Console.WriteLine(word);
            }

            foreach (int[] arrayInteger in arraysOfInts)
            {
                foreach (int number in arrayInteger)
                {
                    Console.WriteLine(number);
                }
            }

            #endregion

            #region Exercise 05

            int[] userArray = new int[5];
            int sumOfNumbers = 0;
            for(int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Enter number {i}: ");
                userArray[i] = int.Parse(Console.ReadLine());
                sumOfNumbers += userArray[i];
            }

            Console.WriteLine("Sum of all numbers in the array is " + sumOfNumbers);


            #endregion
        }
    }
}
