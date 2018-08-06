using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;
namespace Entity
{
    public class LeftJoinWithIfEmptyLocalAndDb
    {
        public void Execute(RestfulServiceDatabaseEntities dbContext)
        {
            var result = from c in dbContext.Customer
                         from p in c.Purchase.DefaultIfEmpty()
                         select new
                         {
                             c.Name,
                             Price = p == null ? (decimal?) null : p.Price,
                             Id = p == null ? (int?) null : p.Id
                         };
        }
    }
}
