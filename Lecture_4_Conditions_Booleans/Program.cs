using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
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



        } // Main

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

    } // class
} // namespace
