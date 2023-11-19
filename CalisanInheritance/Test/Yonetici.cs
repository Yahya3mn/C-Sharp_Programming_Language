using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Yonetici : Calisan
    {
        private int sorumlu_kisi;

        public Yonetici(string name, int salary, string department,int sorumlu_kisi) : base(name, salary, department)
        {
            this.name = name;
            this.salary = salary;   
            this.Department = department;
            this.sorumlu_kisi = sorumlu_kisi;
        }

        public void zam_yap(int zam_miktari)
        {
            Console.WriteLine("Çalışanlara " + zam_miktari + " TL zam yapıldı..");
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("İsim : " + name);
            Console.WriteLine("Maaş : " + salary);
            Console.WriteLine("Departman : " + Department);


            Console.WriteLine("Sorumlu Kişi Sayısı: " + this.sorumlu_kisi);
        }
    }
}
