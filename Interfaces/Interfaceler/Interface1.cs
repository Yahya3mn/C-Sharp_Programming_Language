using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceler
{
    internal interface ICustomeDal
    {
        void Add();
        void Uptade();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomeDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Updated");
        }

        public void Uptade()
        {
            Console.WriteLine("Sql Deleted");
        }
    }

    class OracleCustomerDal : ICustomeDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Updated");
        }

        public void Uptade()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomeDal customeDal)  //Her iki server'da çalışabilir
        {
            customeDal.Add();

        }
    }
}
