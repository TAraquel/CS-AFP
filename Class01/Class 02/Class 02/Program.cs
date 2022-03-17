using System;

namespace Class_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello G8!");

            #region DataTypes
            // declaration
            int integerVariable1;
            // initialization
            integerVariable1 = 5;
            // declaration & initialization
            int integerVariable2 = 10;

            float floatVariable = 23.4F;
            double doubleVariable = 534562345523.23;

            // Strings are always (HAVE TO BE) in double quotes
            string name = "Gorjan";
            name = "Angel";

            // Char operators are always in single quotes
            char operatorVariable = '*';

            bool boolVariable = false;

            long longInteger = 124135324412313254;

            short shortInteger = 22434;

            Console.WriteLine("------------ Data Types ------------");
            Console.WriteLine(integerVariable1);
            Console.WriteLine(integerVariable2);
            Console.WriteLine(floatVariable);
            Console.WriteLine(doubleVariable);
            Console.WriteLine(name);
            Console.WriteLine(operatorVariable);
            Console.WriteLine(boolVariable);
            Console.WriteLine(longInteger);
            Console.WriteLine(shortInteger);

            #endregion

            #region Operators

            Console.WriteLine("------------ Operators ------------");

            // + operator sums two sides if they are numbers
            int sumOfTwoNumbers = 7 + 8;
            Console.WriteLine(sumOfTwoNumbers);

            // + operator concatanates two strings
            Console.WriteLine("4" + "8");

            int modulOperator = 10 % 3;
            Console.WriteLine(modulOperator);

            sumOfTwoNumbers += 10;
            Console.WriteLine("Sum again: " + sumOfTwoNumbers);

            Console.WriteLine(true || false);
            Console.WriteLine(false ^ true);

            bool myBooleanVariable = true;
            myBooleanVariable &= false;
            Console.WriteLine(myBooleanVariable);

            //var someNumber = 9;
            //someNumber = "Angel"; // You can not change the type, even with var



            #endregion

            #region Exercise 01

            Console.WriteLine("------------ Exercise 02 ------------");

            // devision Double
            double doubleOne;
            double doubleTwo;
            doubleOne = 245.222;
            doubleTwo = 987.23;
            double devidedDouble = doubleOne / doubleTwo;

            Console.WriteLine(devidedDouble);

            // devision integer
            int firstInt = 670;
            int secondInt = 59;
            int devidedInt = firstInt / secondInt;

            Console.WriteLine(devidedInt);




            #endregion

            #region Exercise 02

            Console.WriteLine("------------ Exercise 02 ------------");

            string bookString = "Zoki";
            string bookStringTwo = "Poki";
            string sumOfBookString = bookString + " " + bookStringTwo;
            Console.WriteLine(sumOfBookString);

            string stringOne = "9";
            string stringTwo = "5";
            string sumOfStrings = stringOne + stringTwo;
            Console.WriteLine(sumOfStrings);
            // you can check the type of the variable with .GetType() method
            Console.WriteLine(sumOfStrings.GetType());

            #endregion

            #region Exercise 03

            Console.WriteLine("------------ Exercise 03 ------------");
            int broj;
            string zbor;
            broj = 10;
            zbor = "Yo";
            string resultRandom = broj + zbor;
            Console.WriteLine(resultRandom);


            #endregion

            #region Exercise 04

            Console.WriteLine("------------ Exercise 04 ------------");

            int n = 102;
            int m = 5;
            int result = n / m;
            Console.WriteLine(result);

            #endregion

            Console.ReadLine();
        }
    }
}
