using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public static class CustomerDbMethods
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            var dbContext = new RestfulServiceDatabaseEntities();

            return from c in dbContext.Customer select c;
        }
    }
}
