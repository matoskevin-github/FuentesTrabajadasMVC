using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CRUDXMLWithLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //E:\Aplicaciones_NET\CRUDXMLWithLINQ\CRUDXMLWithLINQ\data\products.xml
            string path = @"E:\Aplicaciones_NET\CRUDXMLWithLINQ\CRUDXMLWithLINQ\data\products.xml";
            //Agregar un contenido al fichero XML
            XDocument xdoc = XDocument.Load(path);
            /*XElement product = new XElement("product",
                new XAttribute("id", "p04"),
                new XElement("name", "Product 4"),
                new XElement("price", "4000", new XAttribute("currency", "USD"))
                );
            xdoc.Root.Add(product);
            xdoc.Save(path);*/

            //Eliminar un contenido al fichero XML
            /*  var product = xdoc.Descendants("product").Single(p => p.Attribute("id").Value.Equals("p04"));
              product.Remove();
              xdoc.Save(path);*/

            var product = xdoc.Descendants("product").Single(p => p.Attribute("id").Value.Equals("p03"));
            product.SetElementValue("name", "abc");
            product.SetElementValue("price", 123);
            xdoc.Save(path);
            Console.ReadLine();
        }
    }
}