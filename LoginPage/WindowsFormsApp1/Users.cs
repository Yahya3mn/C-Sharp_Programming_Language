using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Users
    {
        public int id {  get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }

        public Users(int id, string email, string password, string name, string address, int age)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }
}