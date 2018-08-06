using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class CreateDOM
    {
        public void Execute()
        {
            XElement lastName = new XElement("lastname", "kowalski");
            lastName.Add(new XComment("nice name"));
            XElement customer = new XElement("customer");
            customer.Add(new XAttribute("id", 123));
            customer.Add(new XElement("firstname", "jan"));
            customer.Add(lastName);
            Console.WriteLine(customer.ToString());
        }
    }
}
