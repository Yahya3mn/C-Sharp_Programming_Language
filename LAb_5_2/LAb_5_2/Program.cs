using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "Liam";

            Console.WriteLine(person.Name);
        }
    }
}
