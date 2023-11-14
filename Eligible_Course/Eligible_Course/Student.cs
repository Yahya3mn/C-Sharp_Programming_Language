using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eligible_Course
{
    internal class eligible
    {
        
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Midterm { get; set; }
            public int Final { get; set; }

            public eligible(int id, string name, string lastname, int midterm, int final)
            {
            this.Id = id;
            this.FirstName = name;  
            this.LastName = lastname;
            this.Midterm = midterm;
            this.Final = final;
             
            }
            
            public void Info()
            {
                Console.WriteLine(Id + " " +  FirstName + " " + LastName);
            }

            public double Ortalama()
            {
                return Midterm * 0.4 + Final * 0.6;
            }


        

       

       
    }
}
