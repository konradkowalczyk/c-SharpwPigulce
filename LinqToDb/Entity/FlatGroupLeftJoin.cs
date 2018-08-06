using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;

namespace Entity
{
    public class FlatGroupLeftJoin
    {
        public void Execute(RestfulServiceDatabaseEntities dbContext)
        {
            var result = from c in dbContext.Customer
                         join p in dbContext.Purchase on c.ID equals p.Customer_id into custPurchases
                         from cp in custPurchases.DefaultIfEmpty()
                         select new
                         {
                             CustName = c.Name,
                             Price = cp == null ? (decimal?)null : cp.Price
                         };

        }
    }
}
