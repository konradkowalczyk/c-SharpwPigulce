using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class LinqProjectionToDOM
    {
        public void Execute()
        {
            var fakeCustomers = new List<Customer>() { new Customer { Id = 1, FirstName = "jan", LastName = "kowalski" }, new Customer { Id = 2, FirstName = "Andrzej", LastName = "Duda" } };
            var query = from c in fakeCustomers
                        select
                        new XElement("customer", new XAttribute("Id", c.Id),
                        new XElement("firstname", c.FirstName),
                        new XElement("lastname", c.LastName,
                        new XComment("nice name"))
                        );
            var test = query.ToList();
        }
    }
}
