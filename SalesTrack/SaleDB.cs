using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;


namespace SalesTrack
{         // created by Trenton Thompson
   public static class SaleDB
    {
     private const string Path = @"..\..\Sales.xml";
     
     public static List<Sale> GetSales()
        {
            // create the list
            List<Sale> sales = new List<Sale>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Sale node
            if (xmlIn.ReadToDescendant("Sale"))
            {
                // create one Sale object for each Sale node
                do
                {
                    Sale sale = new Sale();
                    xmlIn.ReadStartElement("Sale");
                    sale.Code =
                         xmlIn.ReadElementContentAsString();
                    sale.Description = 
                        xmlIn.ReadElementContentAsString();
                    sale.Price =
                        xmlIn.ReadElementContentAsDecimal();
                    sales.Add(sale);
                }
                while (xmlIn.ReadToNextSibling("Sale"));
            }
            
            // close the XmlReader object
            xmlIn.Close();

            return sales;
        }
        public static void SaveSales(List<Sale> sales)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Sales");

            // write each sale object to the xml file
            foreach (Sale sale in sales)
            {
                xmlOut.WriteStartElement("Sale");
                xmlOut.WriteElementString("Code",
                    sale.Code);
                xmlOut.WriteElementString("Description",
                    sale.Description);
                xmlOut.WriteElementString("Price",
                    Convert.ToString(sale.Price));
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}

