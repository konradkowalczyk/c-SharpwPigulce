using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
namespace LinqToDb
{
    /// <summary>
    /// Useful for paging in web applications (e.g. below page size is 2 so if user clicks on second page below code is used to skip 2 records and take next 2)
    /// </summary>
    public class TakeSkip
    {
        public void Execute(DataContext dataContext)
        {
            var customers = dataContext.GetTable<Customer>();

            var names = customers.Skip(2).Take(2).Select(x=>x.Name);

            foreach (var n in names)
                Console.WriteLine(n);
        }
    }
}
