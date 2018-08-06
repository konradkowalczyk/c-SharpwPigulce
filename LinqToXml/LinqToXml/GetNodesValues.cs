using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class GetNodesValues
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

        //    //foreach (XNode node in bench.Nodes())
        //    //{
        //    //    Console.WriteLine(node.ToString(SaveOptions.DisableFormatting) + ".");
        //    //}

        //    //foreach (XElement e in bench.Elements())
        //    //    Console.WriteLine(e.Name + ": " + e.Value);
        //    IEnumerable<string> query = from toolbox in bench.Elements()
        //                                where toolbox.Elements().Any(x => x.Value.Contains("Pistolet"))
        //                                select toolbox.Value;
        //    var result = query.ToList();
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

            IEnumerable<string> query = from toolbox in bench.Elements()
                                        from tool in toolbox.Elements()
                                        select tool.Value;
            var count = bench.Elements("toolbox").Count();

            var result = query.ToList();
        }

    }
}
