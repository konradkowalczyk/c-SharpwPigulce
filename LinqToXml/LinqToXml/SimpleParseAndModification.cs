using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class SimpleParseAndModification
    {
        public void Execute()
        {
            XElement config = XElement.Parse("<configuration><client enabled=\"true\"><timeout>30</timeout></client></configuration>");

            foreach (XElement child in config.Elements())
                Console.WriteLine(child.Name);

            XElement client = config.Element("client");

            bool enabled = (bool)client.Attribute("enabled");

            client.Attribute("enabled").SetValue(!enabled);

            int timeout = (int)client.Element("timeout");

            client.Element("timeout").SetValue(timeout * 2);

            client.Add(new XElement("retries", 3));

            Console.WriteLine(config);
        }
    }
}
