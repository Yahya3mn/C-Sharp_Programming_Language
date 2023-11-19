using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idman
{
    public class Idman
    {
        
            private int _burpee_sayisi;
            private int _pushup_sayisi;
            private int _situp_sayisi;
            private int _squat_sayisi;

            public int Burpee_sayisi
            {
                get { return _burpee_sayisi; }
                set { _burpee_sayisi = value; }
            }

            public int Pushup_sayisi
            {
                get { return _pushup_sayisi; }
                set { _pushup_sayisi = value; }
            }

            public int Situp_sayisi
            {
                get { return _situp_sayisi; }
                set { _situp_sayisi = value; }
            }

            public int Squat_sayisi
            {
                get { return _squat_sayisi; }
                set { _squat_sayisi = value; }
            }

            
        


        public Idman(int burpee_sayisi, int  pushup_sayisi, int situp_sayisi, int squat_sayisi)
        {
            this._burpee_sayisi=burpee_sayisi;
            this._pushup_sayisi=pushup_sayisi;
            this._situp_sayisi = situp_sayisi;
            this._squat_sayisi=squat_sayisi;
        }

        public void hareketYap(string hareket_turu, int sayi)
        {
            if (hareket_turu.Equals("Burpee"))
            {
                burpeeYap(sayi);
            }
            else if (hareket_turu.Equals("Pushup"))
            {
                pushupYap(sayi);
            }
            else if (hareket_turu.Equals("Situp"))
            {
                situpYap(sayi);
            }
            else if (hareket_turu.Equals("Squat"))
            {
                squatYap(sayi);
            }
            else
            {
                Console.WriteLine("Geçersiz Hareket...");
            }
        }

        public void burpeeYap(int sayi)
        {
            if(_burpee_sayisi == 0)
            {
                Console.WriteLine("Yapılacak burpee kalmadı...");
            }
            if(_burpee_sayisi - sayi < 0)
            {
                Console.WriteLine("Hedeflediğin burpee sayısını geçtin.Tebrikler!");
                _burpee_sayisi = 0;
                Console.WriteLine("Kalan Burpee : " +  _burpee_sayisi);
            }
            else
            {
                _burpee_sayisi -= sayi;

                Console.WriteLine("Kalan burpee sayısı : " + _burpee_sayisi);

            }
        }
        public void pushupYap(int sayi)
        {
            if(_pushup_sayisi == 0)
            {
                Console.WriteLine("Yapacak pushup kalmadı...");
            }
            if(_pushup_sayisi - sayi < 0)
            {
                Console.WriteLine("Hedeflediğin pushup sayısını geçtin.Tebrikler!");
                _pushup_sayisi = 0;
                Console.WriteLine("Kalan Pushup : " +  _pushup_sayisi);
            }
            else
            {
                _pushup_sayisi -= sayi;

                Console.WriteLine("Kalan pushup sayısı : " + _pushup_sayisi);
            }
        }

        public void situpYap(int sayi)
        {
            if(_situp_sayisi == 0)
            {
                Console.WriteLine("Yapacak situp kalmadı.....");
            }
            if(_situp_sayisi - sayi < 0)
            {
                Console.WriteLine("Hedeflediğin situp sayısını geçtin.Tebrikler!");
                _situp_sayisi = 0;
                Console.WriteLine("Kalan situp : " +  _situp_sayisi);   
            }
            else
            {
                _situp_sayisi -= sayi;
                Console.WriteLine("Kalan situp sayısı : " + _situp_sayisi);
            }
        }

        public void squatYap(int sayi)
        {
            if(_squat_sayisi == 0)
            {
                Console.WriteLine("Yapacak squat kalmadı....");
            }
            if(_squat_sayisi - sayi < 0)
            {
                Console.WriteLine("Hedeflediğin squat sayısını geçtin.Tebrikler!");
                _squat_sayisi = 0;
                Console.WriteLine("Kalan squat : " + _squat_sayisi);
            }
            else
            {
                _squat_sayisi -= sayi;
                Console.WriteLine("Kalan squat sayısı : " + _squat_sayisi);
            }
        }

        public Boolean idmanBittiMi()
        {
            return (_burpee_sayisi == 0) && (_situp_sayisi == 0) && (_situp_sayisi == 0) && (_squat_sayisi == 0);
        }

    }
}
