using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_3
{
    internal class Chapter10_Ex1
    {
        static void Main(string[] args)
        {
            ArrayList list_1 = new ArrayList();

            list_1.Add(1);
            list_1.Add("Bill");
            list_1.Add("");
            list_1.Add(true);
            list_1.Add(4.5);
            list_1.Add(null);

            var list_2 = new ArrayList()
            {
                2,"Steve",true,4.5,null
            };



            
            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("world");

            
            list_1.AddRange(arr);
            list_1.AddRange(myQ);

            var arlist = new ArrayList()
            {
                1,
                "Bill",
                300,
                4.5f
            };

            int firstElement = (int)arlist[0];
            string secondElement = (string)arlist[1];

            arlist[0] = "Steve";
            arlist[1] = 100;

            ArrayList List_1 = new ArrayList()
            {
                1,
                "Bill",
                300,
                4.5F
            };


            foreach(var item in list_1)
                Console.WriteLine(item + ", ");


            List_1.Insert(1, "Second Item");

            foreach(var val in  list_1)
                Console.WriteLine(val);


            ArrayList arList1 = new ArrayList()
            {
                100, 200, 600
            };

            ArrayList arlist2 = new ArrayList()
            {
                300,400,500
            };

            arList1.InsertRange(2, arlist2);

            foreach(var item in arList1)
                Console.WriteLine(item + ", ");

            list_1.Remove(null);
            list_1.RemoveAt(4);
            list_1.RemoveRange(0, 2);


            ArrayList arList = new ArrayList()
            {
                1,
                "Bill",
                300,
                4.5f,
                300
            };

            Console.WriteLine(arList.Contains(300));
            Console.WriteLine(arList.Contains("Bill"));
            Console.WriteLine(arList.Contains(10));
            Console.WriteLine(arList.Contains("Steve"));
        }
    }
}
