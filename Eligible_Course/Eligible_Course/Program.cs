using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eligible_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            eligible std = new eligible(2010205614, "Yahya", "Zakrya Khan", 80, 70);

            double x = std.Ortalama();

            if( x >= 90 || x == 100)
            {
                Console.WriteLine(std.Ortalama() + " Mükemmel");
            }
            else if( x >= 80 || x <= 90)
            {
                Console.WriteLine(std.Ortalama() + "Çok iyi");
            }
            else if(x >= 60 || x <= 70)
            {
                Console.WriteLine(std.Ortalama() + "Iyi");
            }
            else if(x >= 40 || x <= 50)
            {
                Console.WriteLine(std.Ortalama() + "Ortalama geçti");
            }
            else
            {
                Console.WriteLine(std.Ortalama() + "Kaldı");
            }

        }
    }
}
