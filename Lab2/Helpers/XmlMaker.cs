using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using System.Windows.Forms;
using System.Reflection;

namespace Lab2
{
    class XmlMaker
    {
        internal void BuildXml(List<Coin> found)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));

            XmlElement root = xmlDoc.CreateElement("Collection");
            xmlDoc.AppendChild(root);
            List<XmlElement> elements = new List<XmlElement>();

            foreach (Coin coin in found)
            {
                XmlElement countryelmt;

                if (xmlDoc.GetElementsByTagName(coin.Attributes["Country"]) != null)
                {
                    XmlAttribute countryattr;

                    countryelmt = xmlDoc.CreateElement("Country");
                    countryattr = makeAttribute(xmlDoc, "ID", coin.Attributes["Country"]);
                    countryelmt.Attributes.Append(countryattr);

                    root.AppendChild(countryelmt);
                }
                else
                {
                    countryelmt = xmlDoc.GetElementById(coin.Attributes["Country"]);
                }

                countryelmt.AppendChild(makeCoinElement(xmlDoc, coin));
            }


            xmlDoc.Save(DataSystemProg.XmlResFile);
        }

        // Створити елемент для запису в doc
        private XmlElement makeCoinElement(XmlDocument doc, Coin coin)
        {

            XmlElement coinelmt;

            coinelmt = doc.CreateElement("Coin");

            foreach (var item in coin.Attributes)
            {
                coinelmt.Attributes.Append(makeAttribute(doc, item.Key, item.Value));
            }

            return coinelmt;
        }


        // Створити атрибут для елемента з doc з іменем tag і значенням value
        private XmlAttribute makeAttribute(XmlDocument doc, string tag, string value)
        {
            XmlAttribute attr = doc.CreateAttribute(tag);
            attr.Value = value;

            return attr;
        }
    }
}
