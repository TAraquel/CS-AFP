using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Branching

            Console.WriteLine("Branching!");
            Console.WriteLine("==================================");

            // IF / ELSE

            //int firstNumber = 5;
            //int secondNumber = 10;

            //if (firstNumber > secondNumber)
            //{
            //    Console.WriteLine("First is bigger than second");
            //}
            //else if (firstNumber < secondNumber)
            //{
            //    Console.WriteLine("First is smaller then second");
            //}
            //else
            //{
            //    Console.WriteLine("They are equal");
            //}


            //Switch
            Console.WriteLine("Switch!");
            Console.WriteLine("==================================");


            int dayOfWeek = 3;

            //switch (dayOfWeek)
            //{
            //    case 1:
            //        Console.WriteLine("Working Day");
            //        break;
            //    case 2:
            //        Console.WriteLine("Working Day");
            //        break;
            //    case 3:
            //        Console.WriteLine("Working Day");
            //        break;
            //    case 4:
            //        Console.WriteLine("Working Day");
            //        break;
            //    case 5:
            //        Console.WriteLine("Working ");
            //        break;
            //    case 6:
            //        Console.WriteLine("Hooray! Weekend!");
            //        break;
            //    case 7:
            //        Console.WriteLine("End od week");
            //        break;
            //    default:
            //        Console.WriteLine("No such day");
            //        break;
            //}


            Console.WriteLine("==================================");

            //switch (dayOfWeek)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Working Day");
            //        break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("WEEKEND!!");
            //        break;
            //    default:
            //        Console.WriteLine("No such day");
            //        break;
            //}


            //Console.ReadLine();

            #endregion

            #region Exercise 05

            //Console.WriteLine("Branching!");
            //Console.WriteLine("==================================");

            //int branches = 12;
            //int applesPerBranch = 8;
            //int basketCanHold = 5;
            //int resultBaskets = 0;
            //int trees;
            //Console.WriteLine("Enter number of trees");
            //bool ifSuccess = int.TryParse(Console.ReadLine(), out trees);

            //int treeApples;

            //if(ifSuccess)
            //{
            //    treeApples = trees * branches * applesPerBranch;

            //    if (treeApples % basketCanHold == 0)
            //    {
            //        resultBaskets = treeApples / basketCanHold;
            //    } 
            //    else
            //    {
            //        resultBaskets = treeApples / basketCanHold + 1;
            //    }

            //    Console.WriteLine("YOu would need " + resultBaskets + " baskets.");

            //}
            //else
            //{
            //    Console.WriteLine("Enter a valid input number");
            //}

            #endregion

            #region Exercise 06

            int userInput;
            bool isUserInputSuccess = int.TryParse(Console.ReadLine(), out userInput);

            if (isUserInputSuccess)
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("You got a new car!");
                        break;
                    case 2:
                        Console.WriteLine("You got a new plane!");
                        break;
                    case 3:
                        Console.WriteLine("You got a new bike!");
                        break;
                    default:
                        Console.WriteLine("You got no reward!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You enterted wrong imput");
            }

            #endregion
        }
    }
}
