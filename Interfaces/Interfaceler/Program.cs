using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            ICustomeDal[] customeDals = new ICustomeDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()

            };

            foreach(var c in customeDals)
            {
                c.Add();
            }
           

            Console.ReadLine();
        }

        private static void Demo()
        { 
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());


        }
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Yahya", LastName = "Zakrya Khan", Address = "Karabük" });

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Bilal",
                LastName = "Çavuş",
                Department = "Bilgisayar Mühendisliği"
            };
            manager.Add(student);


        }
    }
    interface IPerson { //Soyut Nesneler Tek başına bir anlam ifade etmez
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer:IPerson //Somut nesneler
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Address { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department {  get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Id);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}

