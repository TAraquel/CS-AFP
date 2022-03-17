using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Mende", "Pande", "Damjan", "Tomislav", "Samoslav" };

            Console.WriteLine("Enter numbers ( 1 / 2 ) to choose a group!");
            bool correct = int.TryParse(Console.ReadLine(), out int userInput);

            if (correct)
            {
                if(userInput == 1)
                {
                    Console.WriteLine("The students in G1 are:");
                    foreach(string name in studentsG1)
                    {
                        Console.WriteLine(name);
                    }
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("The students in G2 are:");
                    foreach(string name in studentsG2)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}
