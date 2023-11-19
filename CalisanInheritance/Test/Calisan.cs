using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Calisan
    {
        private string isim;
        private int maas;
        private string departman;

        

        public Calisan(string name, int salary, string department)
        {
            this.isim = name;
            this.maas = salary;
            this.departman = departman;
        }

        public void calis()
        {
            Console.WriteLine("Çalışan çalışıyor....");
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Maaş : " +  maas);
            Console.WriteLine("Departman : " + departman);
        }

        public void Departman_Degistir(string yeni_departman)
        {
            Console.WriteLine("Departman değiştiriliyor....");
            this.departman = yeni_departman;

            Console.WriteLine("Yeni departman : " +  this.departman);
        }

        public string name
        {
            get { return isim; }
            set { isim = value; }
        }

        public int salary
        {
            get { return maas;}
            set { maas = value; }
        }

        public string Department
        {
            get { return departman;}
            set { departman = value; }
        }


    }
}
