using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            customerManager.update();
            
            ProductManager productManager = new ProductManager();
            productManager.add();
            productManager.update();   
            
            Customer customer = new Customer();
            customer.City = "Karabük";
            customer.Id = 1;
            customer.FirstName = "Yahya";
            customer.LastName = "Zakrya Khan";

            Customer customer2 = new Customer()
            {
                Id = 2, City = "Karabük", FirstName = "Yahya", LastName = "Zakrya Khan"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();

        }
    }
    class CustomerManager
    {
        public void add()
        {
            Console.WriteLine("Customer added");
        }
        public void update()
        {
            Console.WriteLine("Customer updated");
        }
    }
    class ProductManager
    {
        public void add()
        {
            Console.WriteLine("Product added");
        }
        public void update()
        {
            Console.WriteLine("Pruduct updated");
        }
    }

    class Customer
    {
        //Property
        public int Id { get; set; }
        public string FirstName { get; set; }

       /* private string _firstName;
        public string FirstName
        {
            get
            {
                return "Mr." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }*/
        public string LastName { get; set; }
         public string City { get; set; }
    }      
}
