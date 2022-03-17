using System;

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data entry & conversion");
            Console.WriteLine("==============================");

            #region DataEntry
            //Console.WriteLine("Write your name: ");

            ////Ask for user input and save it in variable
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //Console.WriteLine("Write a number: ");
            //string number = Console.ReadLine();
            //Console.WriteLine(number.GetType());

            #endregion

            #region Conversion

            string numberString = "22";
            string doubleString = "12.7";
            string userInput = "a";
            Console.WriteLine("==============================");

            //Conversion with Parse

            //int parseInt = int.Parse(numberString);
            //Console.WriteLine(parseInt.GetType());

            ////double parse

            //double parseDouble = double.Parse(doubleString);
            //Console.WriteLine(parseDouble.GetType());

            //user Input parse

            //int parseUserInput = int.Parse(userInput);
            //// This throws an exeption because it cant convert "a" to integer
            //Console.WriteLine(parseUserInput.GetType());

            Console.WriteLine("==============================");


            // Conversion with Convert

            //int convertedInt = Convert.ToInt32(numberString);
            //Console.WriteLine("Converted to int " + convertedInt.GetType());

            //double convertedToDouble = Convert.ToDouble(doubleString);
            //Console.WriteLine("Converted to double " + convertedToDouble.GetType());

            //int convertedUserInput = Convert.ToInt32(userInput);
            //Console.WriteLine("Converted to int - user input " + convertedUserInput.GetType() + " - " + convertedUserInput);

            Console.WriteLine("==============================");

            // Conversion with TryParse

            int parseResult;
            bool ifParsingSuccessful = int.TryParse(numberString, out parseResult);
            Console.WriteLine("Was it successful? " + ifParsingSuccessful);
            Console.WriteLine(parseResult);

            Console.WriteLine("==============================");

            bool ifParsingInputSuccessful = int.TryParse(userInput, out int parseInputResult);
            Console.WriteLine("Was it successful? " + ifParsingInputSuccessful);
            Console.WriteLine(parseInputResult);


            Console.WriteLine("==============================");

            Console.WriteLine("Enter age: ");
            bool ifAnotherParsingSuccessful = int.TryParse(Console.ReadLine(), out int userResult);
            Console.WriteLine("Was it successful? " + ifAnotherParsingSuccessful);
            Console.WriteLine(userResult);

            #endregion

            #region Branching (If / Switch)



            #endregion

            Console.ReadLine();
        }
    }
}
