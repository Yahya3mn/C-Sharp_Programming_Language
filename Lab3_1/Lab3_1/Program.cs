using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class Program
    {
        public int FindMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;

        }

        
    }
    class Test
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            Program n = new Program();

            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0} ", ret);
            Console.ReadLine();
        }
    }
}
