using System;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = new string[10];

            for(int i = 0; i < namesArray.Length; i++)
            {
                Console.WriteLine("Enter name: ");
                namesArray[i] = Console.ReadLine();
                Console.WriteLine("Do you want to enter another name (Y /N)");
                string userChoise = Console.ReadLine();
                if (userChoise.ToUpper() == "N") 
                    break;
            }
            foreach(string name in namesArray)
            {
                Console.WriteLine(name);
            }
        }
    }
}
