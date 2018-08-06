using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class ElementLoad
    {
        public void Execute()
        {
            // var webElement = XDocument.Load("http://albahari.com/sample.xml"); sample statement such address does not exist
            var localElement = XElement.Load(@"E:\projekty\c# w pigułce\drafty\LinqToXml\SampleXml.xml");
        }
    }
}
