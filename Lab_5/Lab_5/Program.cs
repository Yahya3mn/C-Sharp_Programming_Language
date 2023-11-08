using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Car1
    {
        public string model;
        public string color;
        public int year;


        public Car1(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;   
        }
    
        static void Main(string[] args)
        {

            Car1 Ford = new Car1("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);  
        }
    }
}
