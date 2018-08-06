using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDb
{
    public class SimpleFluentQuery
    {
        public void Execute(DataContext dataContext)
        {
            Table<Customer> customers = dataContext.GetTable<Customer>();

            IQueryable<string> query = customers.Where(n => n.Name.Contains("a")).Select(n => n.Name);

            foreach (string name in query) Console.WriteLine(name);
        }
    }
}
