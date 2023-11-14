using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_KIMLIK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PEersonel p = new PEersonel();

            p.TCKimliKNO = "99758793838";
            Console.WriteLine("TC Kimlik no : " +  p.TCKimliKNO);
        }
    }
}
