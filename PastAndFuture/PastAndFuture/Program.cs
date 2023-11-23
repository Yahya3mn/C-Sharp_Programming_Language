using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastAndFuture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir tarih giriniz (yyyy-MM-dd): ");
            string tarih = Console.ReadLine();

            if (DateTime.TryParse(tarih, out DateTime date))
            {
                Console.WriteLine($"Tarih : {date:yyyy-MM-dd}");


                DateTime OnBesYilOncesi = date.AddYears(-15);
                Console.WriteLine($"15 yıl önceki tarih : {OnBesYilOncesi:yyyy-MM-dd}");


                DateTime OnBesYilSonrasi = date.AddYears(15);
                Console.WriteLine($"15 yıl sonraki tarih : {OnBesYilSonrasi:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine("Hatalı tarih girişi");
            }
            Console.ReadLine();
        }
    }
}
