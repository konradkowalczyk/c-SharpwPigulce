using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;
namespace Entity
{
    public class FilteredInnerJoinGroupJoin
    {
        public void Execute(RestfulServiceDatabaseEntities dbContext)
        {
            var customers = dbContext.Customer;
            var purchases = dbContext.Purchase;
            var result = from c in customers join p in purchases on 
                         c.ID equals p.Customer_id
                         into custPurchases
                         select new {c.Name, custPurchases };
        }
    }
}
