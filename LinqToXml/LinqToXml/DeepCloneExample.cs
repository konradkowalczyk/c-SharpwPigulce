using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class DeepCloneExample
    {
        public void Execute()
        {
            var address = new XElement("Address",
                new XElement("street", "Klonowa"),
                new XElement("town", "Warszawa"));
            var customer1 = new XElement("customer1", address);
            var customer2 = new XElement("customer2", address);

            customer1.Element("Address").Element("street").Value = "Akacjowa";
            Console.WriteLine(customer2.Element("Address").Element("street").Value);
        }
    }
}
