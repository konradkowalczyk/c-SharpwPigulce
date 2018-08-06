using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataContext = DataContextHelper.GetDataContext();

            var simpleQuery = new NestedQuery();
            simpleQuery.Execute(dataContext);
            Console.ReadKey();
        }
    }
}
