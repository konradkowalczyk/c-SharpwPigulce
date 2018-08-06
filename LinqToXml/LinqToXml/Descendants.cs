using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class Descendants
    {
        //public void Execute()
        //{
        //    var bench = new XElement("bench",
        //        new XElement("toolbox",
        //            new XElement("handtool", "Młotek"),
        //            new XElement("handtool", "Tarnik")),
        //        new XElement("toolbox",
        //            new XElement("handtool", "Piła"),
        //            new XElement("powertool", "Pistolet na gwoździe"),
        //            new XComment("Ostrożnie z pistoletem na gwoździe")));

        //    var descs = from toolbox in bench.Elements()
        //                select toolbox.Descendants();

        //    foreach (var d in descs)
        //        foreach(var e in d)
        //            Console.WriteLine(e.Name);


        //}

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

            //foreach (XNode node in bench.DescendantNodes())
            //    Console.WriteLine(node.ToString(SaveOptions.DisableFormatting));

            IEnumerable<string> query = from c in bench.DescendantNodes().OfType<XComment>()
                                        where c.Value.Contains("Ostrożnie")
                                        select c.Value;

            var result = query.ToList();
        }
    }
}
