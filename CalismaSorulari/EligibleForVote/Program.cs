using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligibleForVote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaşınızı giriniz : ");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (UygunMu(yas))
            {
                Console.WriteLine("Oy kullanmak için uygun yaşa sahipsiniz. Teşekkür ederiz oyunuz için..");
            }
            else
            {
                Console.WriteLine("Oy kullanmak için yaşınız uygun değildir. Oy kullanmak için 18 yaşını doldurmanız gerekiyor..");
            }

        }

        static bool UygunMu(int yas)
        {
            int yas_siniri = 18;
            return yas >= yas_siniri;
        }
    }
}
