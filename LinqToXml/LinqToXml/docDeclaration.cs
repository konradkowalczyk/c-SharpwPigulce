using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    public class docDeclaration
    {
        public void Execute()
        {
            var styleInstruction = new XProcessingInstruction("xml-stylesheet", "href='styles.css', type='text/css'");

            var docType = new XDocumentType("html", "-//W3C//DTD XHTML 1.0 Strict//EN", "http://www.w3c.org/TR/xhtml/DTD/xhtml-strict.dtd", null);

            XNamespace ns = "http://www.w3.org/1999/xhtml";

            var root = new XElement(ns + "html",
                new XElement(ns + "head",
                    new XElement(ns + "title", "An XHTML page")),
                new XElement(ns + "body", 
                    new XElement(ns + "p", "To jest treść"))
                    );

            var doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "no"),
                new XComment("Reference a stylesheet"),
                styleInstruction,
                docType,
                root);

            doc.Save("E:/test.html");
        }
    }
}
