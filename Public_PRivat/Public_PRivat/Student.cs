using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_PRivate
{
    class Student
    {
        public int ogrenciNo {  get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public double vize { get; set; }
        public double Final { get; set; }
        public string OkulIsmi { get; set; }

        public Student(int OgrNO, string name, string surname, double vize, double final, string Okul) {
            ogrenciNo = OgrNO;
            isim = name;
            soyisim = surname;
            vize = vize;
            Final = final;
            OkulIsmi = Okul;
        
        }

        public void OgrenciBilgileriGoster()
        {

            Console.WriteLine(ogrenciNo + " " + isim + " " + soyisim);
        }

    

        public double ogrenciOrtalamasıBul()
        {
            return vize * 0.4 + Final * 0.6;
        }

        public void okulGetir()
        {
            
            Console.WriteLine(OkulIsmi);
        }
    }
    
  
}
