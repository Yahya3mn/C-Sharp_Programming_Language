using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11
{
     class Program
    {
       /* public int FindMaximum(int num1, int num2)
        {
            int result;

            if(num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }*/

        /*public int recFactorial(int k)
        {
            int result;
            if (k == 0)
            {
                return 1;
            }
            else
            {
                result = k * recFactorial(k - 1);
                return result;
            }
        }*/

        public void PassingBYValue_Swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
       
        static void Main(string[] args)
        {
            /*int a = 100;
            int b = 200;
            int ret;
            Program n = new Program();

            ret = n.FindMaximum(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();*/

            /* Program n = new Program();
             Console.WriteLine("Factorial of 7 is : {0}", n.recFactorial(7));
             Console.WriteLine("Factorial of 8 is : {0}", n.recFactorial(8));*/
            Program n = new Program();
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            n.PassingBYValue_Swap(a, b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();

        }
    }
}
