using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yonetici yonetici1 = new Yonetici("Mustafa Murat Coşkun", 2500, "IT", 10);
            yonetici1.BilgileriGoster();
            yonetici1.zam_yap(200);
        }
        }
    }

