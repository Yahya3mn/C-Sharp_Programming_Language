using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_7
{
    internal class Program
    {
        static double OrtalamaHesapla(int[] dizi)
        {
            int toplam = 0;
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            return (double)toplam / dizi.Length;
        }
        static int KareAl(int n)
        {
            return n * n;
        }
       
        static void Main(string[] args)
        {
            /** Ödev8: Klavyeden kullanıcının girdiği 10 elemanlı dizideki her bir elemanın karesi alınacak ve bir fonksiyon yardımı ile ortalaması hesaplanacaktır. Programı yazınız.
*/
            int[] arr = new int[10];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("lütfen {0} elemanı giriniz : ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length ; i++)
            {
                arr[i] = KareAl(arr[i]);
            }
            double ortalama = OrtalamaHesapla(arr);
            Console.WriteLine("Karelerin Ortalaması: " + ortalama);

        }

        
    }
}
