using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı olarak ay değeri giriniz : ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Satı olarak yıl değeri giriniz : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Hatalı giriş 1 ile 12 arası ay giriniz...");
            }
            else
            {
                int gunAy = DateTime.DaysInMonth(year, month);
                Console.WriteLine($"Gün sayısı :{gunAy} gün, Ay :{GetMonthName(month)}, Yıl :{year} ");
            }



            Console.ReadLine();
        }

        static string GetMonthName(int month)
        {

            return new DateTime(1, month, 1).ToString("MMMM");
        }
    }
}
