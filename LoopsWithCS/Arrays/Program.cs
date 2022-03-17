using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");

            //Empty integer array with lenght 3
            int[] emptyIntegerArray = new int[3];
            emptyIntegerArray[0] = 5;
            emptyIntegerArray[1] = 7;
            emptyIntegerArray[2] = 33;

            Console.WriteLine(emptyIntegerArray[1]);

            // Out of range bounderies - emptyIntegerArray[3] = 55;

            string[] stringArray = { "Filip", "Aleksandar", "Stefani" };
            Console.WriteLine(stringArray[1]);

            Console.WriteLine($"StringArray length: {stringArray.Length}");

            //double[] doubleArray = { 2, 33.3, 44.6, 7 }; - mixed arrays are not allowed
            double[] doubleArray = { 2, 33.3, 44.6, 7, 67 };
            //doubleArray[4] = 55.9; - exeption (array limited to number of elements at start)
            //Console.WriteLine(doubleArray[4]);


            //RESIZE
            Array.Resize(ref doubleArray, 7);
            doubleArray[5] = 55.9;

            //INDEX OF
            int indexFound = Array.IndexOf(doubleArray, 44.6);
            Console.WriteLine("Index of 44.6:");
            Console.WriteLine(indexFound);

            int indexNotFound = Array.IndexOf(doubleArray, 5);
            Console.WriteLine("Index of 5:");
            Console.WriteLine(indexNotFound);


            //REVERSE
            Console.WriteLine("===REVERSE===");
            Console.WriteLine(doubleArray[0]);
            Array.Reverse(doubleArray);
            Console.WriteLine(doubleArray[0]);

            string[] names = { "Elena", "Antonio", "Gjorgji", "Jovana", "Bojan" };

            // Iterates each member - similar to for-of in JS
            foreach(string name in names)
            {
                Console.WriteLine(name);
                if(name == "Jovana")
                {
                    break;
                }
            }



            Console.ReadLine();
        }
    }
}
