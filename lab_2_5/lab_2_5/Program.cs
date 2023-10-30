using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];


            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("element - {0} :",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for(int i = 0; i< arr.Length; i++) {
                
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
