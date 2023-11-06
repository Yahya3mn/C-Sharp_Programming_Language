using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            List();


           
            Console.ReadLine();
        }
        private static void ArrayList()
        { 
            var cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var c in cities)
            {
                Console.WriteLine(c);
            }
            cities.Add("Istanbul");
            Console.WriteLine(cities[2]);
           

        }
        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Istnabul");

            //Console.WriteLine(cities.Contains("Ankara")); TRUE, FALSE

            List<Customer> customers = new List<Customer>()
            {
                new Customer{Id = 1, Firstname = "Yahya", Lastname = "Zakrya Khan"}

            };
            
            var customer = new Customer
            {
                Id = 3,
                Firstname = "Salih",
                Lastname = "Emini"
            };
            customers.Add(customer);
            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 4, Firstname = "Ali", Lastname = "sksksk"},
                new Customer { Id = 5, Firstname = "Ali", Lastname = "sksksk"}
                

            });
            var Index =  customers.IndexOf(customer);
            Console.WriteLine("Index : {0} ",Index);
           // customers.Clear();
            
            //customers.Add(new Customer { Id = 1, Firstname = "Yahya", Lastname = "Zakrya Khan" });
            foreach(var c in customers)
            {
                Console.WriteLine(c.Firstname);
            }
            var count = customers.Count();
            Console.WriteLine("Count : {0}", count);

        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
