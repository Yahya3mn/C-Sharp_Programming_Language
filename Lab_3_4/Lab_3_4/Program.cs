using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Odev
{
    internal class Program
    {
       
        class Kisi
        {
            public string Ad;
            public string Soyad;
            public DateTime DogumTarihi;
        }

        static void Main(string[] args)
        {


            List<Kisi> kisiler = new List<Kisi>();

            
            for (int i = 0; i < 10; i++)
            {
                Kisi kisi = new Kisi();
                Console.Write("Kişi #" + (i + 1) + " Adı: ");
                kisi.Ad = Console.ReadLine();
                Console.Write("Kişi #" + (i + 1) + " Soyadı: ");
                kisi.Soyad = Console.ReadLine();
                Console.Write("Kişi #" + (i + 1) + " Doğum Tarihi (yyyy-MM-dd formatında): ");
                kisi.DogumTarihi = DateTime.Parse(Console.ReadLine());
                kisiler.Add(kisi);
            }


            
            DateTime bugun = DateTime.Now;
            foreach (var kisi in kisiler)
            {
                int yas = bugun.Year - kisi.DogumTarihi.Year;
                if (bugun < kisi.DogumTarihi.AddYears(yas)) yas--;
                Console.WriteLine(kisi.Ad + " " + kisi.Soyad + " - Yaş: " + yas);
            }

            
            kisiler.Sort((x, y) => x.DogumTarihi.CompareTo(y.DogumTarihi));

            
            Console.WriteLine("Sıralanmış Liste:");
            foreach (var kisi in kisiler)
            {
                Console.WriteLine(kisi.Ad + " " + kisi.Soyad + " - Doğum Tarihi: " + kisi.DogumTarihi.ToString("yyyy-MM-dd"));
            }


        }
    }
}
