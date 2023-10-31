using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capter_7_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Ödev 3:0-100 arasındaki çift sayıları yazdırırken sayı=60 olduğunda döngünden çıkan programı yazınız.
                (Exit the for loop örneği yazılıyor.)
                Ödev 4: Continue the for loop
                Ödev 5: Continue while loop code   */


            // Ödev 3 ,4 , 5

            for(int i = 0; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Cift sayi" + i);
                    if(i == 60)
                    {
                        Console.WriteLine("Sayı 60 olduğunda döngüden çıkılıyor..");
                        break;
                    }
                }
            }


           


            
           

            

         
        }
    }
}
