using Public_PRivate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_PRivat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ogrenci = new Student(2010205614, "Yahya", "Zakrya Khan", 60, 80, "Karabük Üniversitesi");

            int secim;

            Console.WriteLine("Lütfen seçim yapınız..");
            Console.WriteLine("0- Öğrenci Bilgeri Göster");
            Console.WriteLine("1 - Öğrenci Ortalaması Hesapla");
            Console.WriteLine("2 - Öğrencinin Okulunu Öğren");
    
            secim = Convert.ToInt32(Console.ReadLine());

            switch(secim)
            {
                case 0:
                    ogrenci.OgrenciBilgileriGoster();
                    break;
                case 1:
                    Console.WriteLine(ogrenci.ogrenciOrtalamasıBul());
                    break;
                case 2:
                    ogrenci.okulGetir();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim");
                    break;
                    
            }
        }
    }
}
