using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;

namespace Entity
{
    public class JoinWithJoinSyntax
    {
        public void Execute(RestfulServiceDatabaseEntities dbContext)
        {
            IEnumerable<string> query = from c in dbContext.Customer
                         join p in dbContext.Purchase on new {K1 = c.ID, K2 = c.ID } equals new {K1 = (int)p.Customer_id, K2 = (int)p.Customer_id }
                         select c.Name + " kupił za kwotę " + p.Price + " w transakcji o id " + p.Id ;
            foreach (var s in query)
            {
                Console.WriteLine(s);
            }
        }
    }
}
