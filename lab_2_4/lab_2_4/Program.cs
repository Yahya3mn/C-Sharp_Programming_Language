using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***   ARRAYLIST APPLICATION   ***/


            ArrayList list_1 = new ArrayList();
            //var list_1 = new ArrayList();


            list_1.Add(1);
            list_1.Add("Bill");
            list_1.Add(" ");
            list_1.Add(true);
            list_1.Add(4.5);
            list_1.Add(null);


            var list_2 = new ArrayList()
            {
                2, "Steve", " ", true, 4.5, null
            };



            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();

            myQ.Enqueue("Hello");
            myQ.Enqueue("World");

            list_1.AddRange(list_2);
            list_1.AddRange(arr);
            list_1.AddRange(myQ);



            int firstElement = (int)list_1[0];
            string secondElement = (string)list_1[1];   
            Console.WriteLine(firstElement);



            list_1[0] = "Steve";
            list_1[1] = 100;


            foreach(var item in list_1)
                Console.WriteLine(item + ", ");


            list_1.Insert(1, "Second Item");

            foreach (var val in list_1) 
                Console.WriteLine(val);

            var arlist1 = new ArrayList()
            {
                100, 200, 300
            };

            var arlist2 = new ArrayList() {
                400, 500, 600
            };

            arlist1.InsertRange(2, arlist2);

            foreach(var item in arlist1)
                Console.WriteLine(item + ", ");


            list_1.Remove(null);
            list_1.RemoveAt(4);
            list_1.RemoveRange(0,2);



            var arlist = new ArrayList()
            {
                1,
                "Bill",
                300,
                4.5f,
                300
            };


            Console.WriteLine(arlist.Contains(300));
            Console.WriteLine(arlist.Contains("Bill"));
            Console.WriteLine(arlist.Contains(10));
            Console.WriteLine(arlist.Contains("Steve"));

        }
    }
}
