using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new RestfulServiceDatabaseEntities();
            var query = new LookUpp();
            query.Execute(dbContext);
        }
    }
}
