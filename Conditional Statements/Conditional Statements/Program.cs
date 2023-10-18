using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int a = 5;       ----------------------------> Exercise 1
             int b = 5;

             if(a == b)
             {
                 Console.WriteLine("Numbers are equal");
             }
             else
             {
                 Console.WriteLine("Numbers are not equal");
             }*/



            /*-------------------------------------------------------------------------------------------------------------*/



            /* int num1;        ------------------------------> Exercise 2
             int num2;
             Console.Write("\n\n");
             Console.Write("Check whether a number is even or odd : \n");
             Console.Write("Input an Integer : ");
             num1 = Convert.ToInt32(Console.ReadLine());
             num2 = num1 % 2;
             if(num2 == 0)
             {
                 Console.WriteLine("{0} is an even integer .\n", num1);
             }
             else
             {
                 Console.WriteLine("{0} is an odd integer .\n", num1);
             }*/

            /*------------------------------------------------------------------------------------------------------------*/



            /*int number;      ------------------------------------------------> exercise 3

             Console.Write("Enter a number : ");
             number = Convert.ToInt32(Console.ReadLine());

             if(number >= 0)
             {
                 Console.WriteLine("{0} is a positive number. \n", number);
             }
             else
             {
                 Console.WriteLine("{0} is a negative number. \n", number);
             }*/


            /*----------------------------------------------------------------------------------------------------------------*/


            /*int m, n;     --------------------------------------------------> exercise 4

            Console.Write("Enter a number : ");
            m = Convert.ToInt32(Console.ReadLine());

            if(m != 0)
            {
                if(m > 0)
                {
                    n = 1;
                }
                else { n = -1; }
            }
            else
            {
                n = 0;
            }
            Console.WriteLine("Value of m = " + m);
            Console.WriteLine("Value of n = " + n);*/



            /*----------------------------------------------------------------------------------------------------------------*/



           /* float Height;      -----------------------------------------------------------------> exercise 5

            Console.Write("\n\n");
            Console.Write("Accept the height of a person in centimeter and categorize them:\n");
            Console.Write("********************************************************************");
            Console.Write("\n\n");


            Console.Write("Please enter height (in centimeters) :");
            Height  = Convert.ToInt32(Console.ReadLine());

            if(Height < 150)
            {
                Console.Write("The person is Dwarf .\n\n");
            }
            else if((Height >= 150.0) && (Height <= 165.0))
            {
                Console.Write("The person is average heighted. \n\n");
            }
            else if((Height >= 165.0) && (Height <= 190.0))
            {
                Console.Write("The person is taller. \n\n");
            }
            else
            {
                Console.Write("Abnormal height. \n");
            }*/



            /*---------------------------------------------------------------------------------------------------------------*/


           /* int num1, num2, num3; --------------------------------------------------------------------> exercise 6

            Console.Write("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\n");

            Console.Write("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\n");

            Console.Write("Enter third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\n");

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The first number is the greatest among three number.");
            }
            else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The second number is the greatest amomg three number.");
            }
            else
            {
                Console.WriteLine("The third number is the greatest among three number. ");
            }*/



            /*----------------------------------------------------------------------------------------------------------*/



            //C Q
        }
    }
}
