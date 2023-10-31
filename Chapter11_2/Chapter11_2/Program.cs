using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11_2
{
    internal class Program
    {
       /* public void Passing_byReference_Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }*/
       public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        static void Main(string[] args)
        {
            /*Program n = new Program();
            int x = 100;
            int y = 200;

            Console.WriteLine("Before swap, value of a : {0}", x);
            Console.WriteLine("Before swap, value of b : {0}", y);

            n.Passing_byReference_Swap(ref x, ref y);

            Console.WriteLine("After swap, value of a : {0}", x);
            Console.WriteLine("After swap, value of b : {0}", y);*/

            Program n = new Program();

            int a = 100;

            n.getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();
        }
    }
}
