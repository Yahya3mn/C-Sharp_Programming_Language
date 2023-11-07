using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum Calisanlar : byte
        {
            idareci, //Çalışan tipi 0
            ogretmen, //Çalışan tipi 1
            memur, //Çalışan tipi 2
            hizmetli //Çalışan tipi 3
        }
        static void Main(string[] args)
        {
            int CalisanTipi;
            Console.WriteLine("çalışan tipini giriniz :");
            CalisanTipi = Convert.ToInt32(Console.ReadLine());

            switch(CalisanTipi)
            {
                case 0:
                    Console.WriteLine("Çalışan tipi : " + Calisanlar.idareci + " Maaş : 100TL");
                    break;
                case 1:
                    Console.WriteLine("Çalışan tipi : " + Calisanlar.ogretmen + " Maaş : 200TL");
                    break;
                case 2:
                    Console.WriteLine("Çalışan tipi : " + Calisanlar.memur + " Maaş : 300Tl");
                    break;
                case 3:
                    Console.WriteLine("Çalışan tipi : " + Calisanlar.hizmetli + " Maaş : 400TL");
                    break;
            }
        }
    }
}
