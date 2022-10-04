using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_Conditions_Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //7.A milk carton can hold 3.78 liters of milk.Each morning, a dairy farm ships cartons of milk to a local grocery store.The cost of producing one liter of milk is $0.38, and the profit of each carton of milk is $0.27.Write a program that does the following:

            double capacityOfContainer = 3.78;
            double costToProduce = .38;
            double profit = .27;

            //a.Prompts the user to enter the total amount of milk produced in the morning.
            Console.Write("How much milk produced this morning: ");
            string milkProducedStr = Console.ReadLine();
            double milkProducedNum = double.Parse(milkProducedStr);

            //b.Outputs the number of milk cartons needed to hold milk. (Round your answer to the nearest integer.)
            // 1 carton equals 3.78 liters
            // userNum of how man liters in a day.
            double numberOfCartons = milkProducedNum / capacityOfContainer;
            double numberofCartonsRounded = Math.Round(numberOfCartons);
            // Math library


            Console.WriteLine($"Number of cartons produced: {numberofCartonsRounded}");

            //c.Outputs the cost of producing milk.
            double todaysCostToProduce = (milkProducedNum * costToProduce);
            Console.WriteLine("The cost to produce milk today was " + todaysCostToProduce);

            //d.Outputs the profit for producing milk.
            double totalProfit = numberofCartonsRounded * profit;
            Console.WriteLine("The profit for today was " + totalProfit);


            Console.ReadKey();
        } // Main

        public static void AgeCheck()
        {
            while (true)
            {
                Console.Write("What is your age?");
                string userInput = Console.ReadLine();
                int userNum = int.Parse(userInput);

                if (userNum >= 70)
                {
                    Console.WriteLine("WHy are you here, retire.");
                }
                else if (userNum >= 21)
                {
                    Console.WriteLine("You may enter this completely legal, and family friendly site");
                }

                else
                {
                    Console.WriteLine("YOu have to wait till you are 21");
                }

                // == and != 
            }

        }

        public static void ComparisonOperator()
        {
            // Comparison Operators
            // == - equals
            // != - not equal

            // > - Great than
            // < - less than
            // >= - greater than equal to
            // <= - less than equal to

            // Equals
            Console.WriteLine(6 == 6); // True
            Console.WriteLine(6 == 8); // False

            // Not Equals !+
            Console.WriteLine(6 == 6); // False
            Console.WriteLine(6 != 8); // True

            Console.WriteLine("Greater than");
            // Greater Than
            Console.WriteLine("6 > 4: " + (6 > 4)); // True
            Console.WriteLine("6 > 8: " + (6 > 8)); // False
            Console.WriteLine("6 > 6: " + (6 > 6)); // False


            Console.WriteLine("Greater than or equal to");
            // Greater Than or Equal To
            Console.WriteLine("6 >= 4: " + (6 >= 4)); // True
            Console.WriteLine("6 >= 8: " + (6 >= 8)); // False
            Console.WriteLine("6 >= 6: " + (6 >= 6)); // False

            Console.WriteLine("Less than");
            // Greater Than
            Console.WriteLine("6 < 4: " + (6 < 4)); // True
            Console.WriteLine("6 < 8: " + (6 < 8)); // False
            Console.WriteLine("6 < 6: " + (6 < 6)); // False


            Console.WriteLine("Less than or equal to");
            // Greater Than or Equal To
            Console.WriteLine("6 <= 4: " + (6 <= 4)); // True
            Console.WriteLine("6 <= 8: " + (6 <= 8)); // False
            Console.WriteLine("6 <= 6: " + (6 <= 6)); // False

        }

        public static void Menu()
        {
            bool isRunning = true;

            while (isRunning)
            {
                // Content from class -------------------------
                Console.WriteLine("1 - Math Example");
                Console.WriteLine("2 - Question 1");
                Console.WriteLine("3 - If Else Example");
                Console.WriteLine("5 - Comparison Operator");
                Console.WriteLine("6 - Exit the app");
                Console.Write("Enter a choice: ");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    MathExample();
                }
                else if (userInput == "2")
                {
                    Question1();
                }
                else if (userInput == "3")
                {
                    IfElseExample();
                }
                else if (userInput == "4")
                {
                    ComparisonOperator();
                }
                else if (userInput == "5")
                {
                    isRunning = false;
                }

                else
                {
                    Console.WriteLine("Please enter a valid selection.");
                }

                // -------------------------------
            } // while loop

            Console.WriteLine("Good bye");
        }

        public static void IfElseExample()
        {
            // Boolean = True or false
            bool torf = true;
            bool tf = false;

            // Comparison
            // == - are equal
            bool areEqual = 6 == 6.5;

            Console.WriteLine("Enter your user name: ");
            string userName = Console.ReadLine();

            int accessNumber = 0;

            string currentUserName = "RTC120";

            bool isCorrect = userName == currentUserName;

            // Conditions
            if (isCorrect)
            {

                Console.WriteLine("Welcome Boss");
                accessNumber = 1;
            } // if
            else
            {
                Console.WriteLine("You shouldn't be here.");
                //accessNumber = 10;

            } // else

            //--------------------------------------------

            if (accessNumber == 1)
            {
                Console.WriteLine("You make way to much money.");
            }
            else if (accessNumber == 10)
            {
                Console.WriteLine("Welcome Valued Customer");
            }
            else // If none of the other conditions are true, else will run
            {
                Console.WriteLine("Please buy something to pay my bosses stupid salary.");
            }
        }

        public static void MathExample()
        {
            //Adding Slightly over 100:
            //The restaurant has 175 normal chairs and 20 chairs for babies.How many chairs does the restaurant have in total ?
            Console.Write("How many chairs are there: ");
            // Number of normal chairs
            string strOfChairs = Console.ReadLine();
            int numOfChairs = int.Parse(strOfChairs);


            // Number of chairs for babys
            Console.Write("\nEnter the number of baby chairs: ");
            string strBabyChair = Console.ReadLine();
            int babyChair = int.Parse(strBabyChair);

            // How many total chairs
            int sum = numOfChairs + babyChair;

            Console.WriteLine("The number of chairs is " + sum);
        } 

        public static void Question1()
        {

            //            1.Write a program that prompts the user to input five decimal numbers.  Your program should do the following:

            //  a.Prompts the user to input five decimal numbers.
            Console.WriteLine("Enter 5 decimal numbers");

            Console.Write("Enter number 1: ");
            string num1str = Console.ReadLine();
            decimal num1 = decimal.Parse(num1str);

            Console.Write("Enter number 2: ");
            string num2str = Console.ReadLine();
            decimal num2 = decimal.Parse(num2str);

            Console.Write("Enter number 3: ");
            string num3str = Console.ReadLine();
            decimal num3 = decimal.Parse(num3str);

            Console.Write("Enter number 4: ");
            string num4str = Console.ReadLine();
            decimal num4 = decimal.Parse(num4str);

            Console.Write("Enter number 5: ");
            string num5str = Console.ReadLine();
            decimal num5 = decimal.Parse(num5str);


            //  b.Prints the five decimal numbers.
            Console.WriteLine($" {num1} - {num2} - {num3} - {num4} - {num5}");
            //  c.Add the five decimal numbers.
            decimal sum = num1 + num2 + num3 + num4 + num5;

            //  d.Print the sum and the average of the five decimals. Calculating the sum and the average are two separate calculations.
            decimal averge = sum / 5;
            Console.WriteLine($"Sum: {sum}\n" +
                $"Average {averge}");

        }

    } // class
} // namespace
