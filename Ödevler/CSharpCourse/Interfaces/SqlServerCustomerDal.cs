using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Deleted!");
        }

        public void Update()
        {
            CXonsole.WriteLine("Sql Server Updated!");
        }
    }
}
