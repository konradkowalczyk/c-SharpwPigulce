using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Linq;

namespace LinqToDb
{
    public class SqlLikeQuery
    {
        public void Execute(DataContext dataContext)
        {
            var customers = dataContext.GetTable<Customer>();

            IQueryable<string> names = from c in customers where SqlMethods.Like(c.Name, "%" + c.Name + "%") select c.Name;

            foreach (var name in names)
                Console.WriteLine(name);
        }

    }
}
