using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isLeap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Yıl giriniz : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (YilMi(year))
            {
                Console.WriteLine(year + " bir artık yıldır");
            }
            else
            {
                Console.WriteLine(year + " Artık bir yıl değil.");
            }
        }

        static bool YilMi(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
    
}
