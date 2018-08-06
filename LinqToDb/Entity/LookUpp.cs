using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;

namespace Entity
{
    public class LookUpp
    {
        public void Execute(RestfulServiceDatabaseEntities dbContext)
        {
            var purchLookup = dbContext.Purchase.ToLookup(p => p.Customer_id, p => p);
            SelectManyWithLookup(purchLookup, dbContext);
        }
        /// <summary>
        /// Implementation of join using lookup plus selectmany
        /// </summary>
        public void SelectManyWithLookup(ILookup<int?, Purchase> purchaseLookup, RestfulServiceDatabaseEntities dbContext)
        {
            var result = from c in dbContext.Customer
                         from p in purchaseLookup[c.ID]
                         select new { c.Name, p.Id, p.Price };

        }
        /// <summary>
        /// Using lookup and selectmany to implement outer join
        /// </summary>
        public void OuterJoinWithLookup(ILookup<int?, Purchase> purchaseLookup, RestfulServiceDatabaseEntities dbContext)
        {
            var result = from c in dbContext.Customer
                         from p in purchaseLookup[c.ID].DefaultIfEmpty()
                         select new {
                             c.Name,
                             TheId = p == null ? (int?)null  : p.Id,
                             ThePrice = p == null ? (decimal?) null :  p.Price,
                         };
            var ff = result.ToArray();
        }
    }
}
