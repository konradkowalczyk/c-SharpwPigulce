using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class ElementParse
    {
        public void Execute()
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><customer id=\"123\" status=\"archived\"><firstname>Jan</firstname><lastname>kowalski</lastname></customer>";
            XElement customer = XElement.Parse(xml);
        }
    }
}
