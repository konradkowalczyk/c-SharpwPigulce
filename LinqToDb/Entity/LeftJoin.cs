using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LeftJoin
    {
        /// <summary>
        /// Returns all customers and only those purchases which were priced above 5
        /// </summary>
        public void Execute(RestfulServiceDatabaseEntities dbContext)
        {
            var result = from c in dbContext.Customer
                         select new
                         {
                             c.Name,
                             Purchases = from p in c.Purchase
                                         where p.Price > 5
                                         select new { p.Id, p.Price }
                         };
        }
    }
}
