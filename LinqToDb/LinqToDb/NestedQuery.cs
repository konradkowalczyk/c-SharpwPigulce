using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDb
{
    public class NestedQuery
    {
        public void Execute(DataContext dataContext)
        {
            var purchases = dataContext.GetTable<Purchase>();
            var customers = dataContext.GetTable<Customer>();

            var purchasesFromDB = purchases.Select(x => x);

            var selectedPurchases = from c in customers
                                    where c.Purchases.Any(x => x.Price > 10)
                                    select new
                                    {
                                        c.Name,
                                        Purchases = from p in c.Purchases where p.Price > 10 select new { p.Price }
                                    };


        }
    }
}
