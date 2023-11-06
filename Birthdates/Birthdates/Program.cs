using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthdates
{
    class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Users> user = new List<Users>()
            {
                new Users{FirstName = "Yahya", LastName = "Zakrya Khan", BirthDate = new DateTime(2000, 04, 14)},
                new Users{FirstName = "Bilal", LastName = "Çavuş", BirthDate = new DateTime(2000, 11, 30)},
                new Users{FirstName = "Yusuf", LastName = "Bakkal", BirthDate = new DateTime(2001, 09, 28)},
                new Users{FirstName = "Kadir", LastName = "Albayrak", BirthDate = new DateTime(2001, 09, 25)},
                new Users{FirstName = "Ismail Enes", LastName = "Yardibi", BirthDate = new DateTime(2001, 07, 31)},
                new Users{FirstName = "Bora Sezer", LastName = "Çetin", BirthDate = new DateTime(2001, 07, 09)},
                new Users{FirstName = "Ayşe", LastName = "Ahmetoğlları", BirthDate = new DateTime(2003, 04, 28)},
                new Users{FirstName = "Rabia", LastName = "Ahmetoğulları", BirthDate = new DateTime(2001, 10, 27)},
                new Users{FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1998, 04, 04)},
                new Users{FirstName = "Dwayne", LastName = "Johnson", BirthDate = new DateTime(1980, 04, 14)}

            };

            DateTime present = DateTime.Now;

            foreach(var u in user)
            {
                int year = present.Year - u.BirthDate.Year;
                if (present < u.BirthDate.AddYears(year)) year--;
                Console.WriteLine(u.FirstName + " " + u.LastName + " - Years old : " + year );
            }

            user.Sort((x, y) => x.BirthDate.CompareTo(y.BirthDate));

            Console.Write("\n\n\n");

            Console.WriteLine("Sorted List :");

            foreach(var u in user)
            {
                Console.WriteLine(u.FirstName + " " + u.LastName + " " + u.BirthDate.ToString("yyyy-MM-dd"));
            }
        }
    }
}
