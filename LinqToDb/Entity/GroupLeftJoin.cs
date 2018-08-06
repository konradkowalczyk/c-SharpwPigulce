using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;

namespace Entity
{
    public class GroupLeftJoin
    {
        public void Execute(RestfulServiceDatabaseEntities dbContext)
        {
            var result = from c in dbContext.Customer
                         join p in dbContext.Purchase on c.ID equals p.Customer_id
                         into customerPurchases
                         where customerPurchases.Any()
                         select new { c, customerPurchases };
        }
    }
}
