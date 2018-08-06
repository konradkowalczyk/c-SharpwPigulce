using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class CheckParent
    {
        public void Execute()
        {
            var bench = new XElement("bench",
                new XElement("toolbox",
                    new XElement("handtool", "Młotek"),
                    new XElement("handtool", "Tarnik")),
                new XElement("toolbox",
                    new XElement("handtool", "Piła"),
                    new XElement("powertool", "Pistolet na gwoździe"),
                    new XComment("Ostrożnie z pistoletem na gwoździe")));

            bench.Element("toolbox").Element("handtool").AddAfterSelf(new XElement("newhandtool"));
            foreach (XNode node in bench.Nodes())
                Console.WriteLine(node);
        }
    }
}
