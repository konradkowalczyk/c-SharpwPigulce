using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace LinqToXml
{
    public class CreateDOMFunctionLanguage
    {
        public void Execute()
        {
            XElement customer = new XElement("customer", new XAttribute("id", 123), new XElement("firstname", "jan"), new XElement("lastname", "kowalski", new XComment("nice name")));
        }
    }
}
