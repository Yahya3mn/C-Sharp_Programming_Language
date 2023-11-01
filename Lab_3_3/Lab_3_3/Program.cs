using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_3
{
    internal class Program
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        static void Main(string[] args)
        {
            Program n = new Program();

            int a = 100;

            Console.WriteLine("Before method call, value of a :"+ a);

            n.getValue(out a);

            Console.WriteLine("After method call, value of a :" + a);
        }
    }
}
