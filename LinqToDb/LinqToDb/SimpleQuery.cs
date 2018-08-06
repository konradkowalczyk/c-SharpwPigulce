using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace LinqToDb
{
    public class SimpleQuery
    {
        public void Execute(DataContext dataContext)
        {
            Table<Customer> customers = dataContext.GetTable<Customer>();

            IQueryable<string> query = from c in customers
                                       where c.Name.Contains("d")
                                       orderby c.Name.Length
                                       select c.Name.ToUpper();

            foreach (string name in query) Console.WriteLine(name);
        }
    }
}
