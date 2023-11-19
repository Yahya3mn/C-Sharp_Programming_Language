using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Idman programına hoşgeldiniz...");

            string idmanlar = "Geçerli Hareketler...\n" +
                              "Burpee\n" +
                              "Pushup(Şınav)\n" +
                              "Situp(Mekik)\n" +
                              "Squat";
            Console.WriteLine(idmanlar);

            Console.WriteLine("Idman oluşturun...");

            Console.Write("Burpee sayısı : ");
            int burpee = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pushup sayısı : ");
            int pushup = Convert.ToInt32(Console.ReadLine());
            Console.Write("Situp sayısı : ");
            int situp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Squat sayısı : ");
            int squat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Idman s = new Idman(burpee, pushup, situp, squat);

            Console.WriteLine("Idmanınız başlıyor....");

            while(s.idmanBittiMi() == false)
            {
                Console.Write("Hareket Türü(Burpee,Pushup,Situp,Squat) : ");
                string tur = Convert.ToString(Console.ReadLine());
                Console.Write("Bu hareketten kaç tane yapacaksınız ? : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                s.hareketYap(tur, sayi);
            }

            Console.WriteLine("Idmanını başarıyla bitirdin....");
        }
    }
}
