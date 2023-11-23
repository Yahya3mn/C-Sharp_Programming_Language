using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAndNameWithComa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen isim ve yaşınızı giriniz (isim,yaş). Bitirmek için boş bir satır girin : ");

            List<Person> people = new List<Person>();

            string input;
            while(!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
            {
                string[] parts = input.Split(',');
                if (parts.Length == 2 && int.TryParse(parts[1], out int yas))
                {
                    people.Add(new Person { name = parts[0], yas = yas });
                }
                else
                {
                    Console.WriteLine("Hatalı giriş. Lütfen (isim,yaş) formatında yazınız..");
                }
                Person oldestPerson = GetOldestPerson(people);

                if(oldestPerson != null)
                {
                    Console.WriteLine("En yaşlı kişi : " +" "+  oldestPerson.name + " "+oldestPerson.yas + " Yaşında");
                }
                else
                {
                    Console.WriteLine("Hatalı giriş...");
                }
                Console.ReadLine();
            }
        }
        static Person GetOldestPerson(List<Person> people)
        {
            Person oldestPerson = null;
            foreach (Person person in people)
            {
                if(oldestPerson == null || person.yas > oldestPerson.yas)
                {
                    oldestPerson = person;
                }
            }
            return oldestPerson;
        }
        class Person
        {
            public string name { get; set; }
            public int yas { get; set; }
        }
    }
}
