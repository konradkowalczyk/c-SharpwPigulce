using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;
namespace Entity
{
    public class OrderBy
    {
        /// <summary>
        /// Those two queries return same results
        /// </summary>
        /// <param name="dbContext"></param>
        public void Execute(RestfulServiceDatabaseEntities dbContext)
        {
            var resultQuery = from p in dbContext.Purchase
                         orderby p.Id, p.Price
                         select p;

            var resultFluent = dbContext.Purchase.OrderBy(x => x.Id).ThenBy(x => x.Price);
        }
    }
}
