using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtayaKarısıkSoru
{
    internal class Program
    {
        static void Main()
        {
            // Örnek bir sınıf tanımlama
            Person person = new Person();

            // Set metodu ile değer atama
            person.SetName("Ahmet");
            person.SetAge(30);

            // Set metodları kullanılarak ArrayList yapısına değer ekleme
            ArrayListExample(person);

            // Tarih ve zaman ifadeleriyle oynama
            DateTimeExpressions();
        }

        // Örnek bir sınıf
        class Person
        {
            private string name;
            private int age;

            // Set metodları
            public void SetName(string n)
            {
                name = n;
            }

            public void SetAge(int a)
            {
                age = a;
            }

            public string GetName()
            {
                return name;
            }

            public int GetAge()
            {
                return age;
            }
        }

        // ArrayList yapısına örnek kullanım
        static void ArrayListExample(Person person)
        {
            List<Person> personList = new List<Person>();

            // Person nesnesini ArrayList'e ekleme
            personList.Add(person);

            // ArrayList'ten değerleri alıp gösterme
            foreach (Person p in personList)
            {
                Console.WriteLine($"Kişi Adı: {p.GetName()}, Yaşı: {p.GetAge()}");
            }
        }

        // Tarih ve zaman ifadeleriyle oynama
        static void DateTimeExpressions()
        {
            // Şu anki tarih ve zaman
            DateTime now = DateTime.Now;
            Console.WriteLine("Şu anki zaman: " + now);

            // Belirli bir tarih oluşturma
            DateTime customDate = new DateTime(2023, 11, 23);
            Console.WriteLine("Özel tarih: " + customDate);

            // Zaman aralıkları
            TimeSpan interval = now - customDate;
            Console.WriteLine("Aradaki zaman farkı: " + interval.Days + " gün");
        }
    }
}
