using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml;
using System.Xml.Linq;

namespace Lab2
{
    class Coin
    {
        public string Country = null;
        public string Type = null;
        public string Year = null;
        public string Value = null;
        public string CurrencyUnit = null;
        public string Shape = null;
        public string Composition = null;
        public string Edge = null;
        public string Subject = null;

        public override string ToString()
        {
            string result = "";

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Країна: {0}\nТип: {1}\nРік: {2}\nНомінал: {3}\nВалютна одиниця: {4}\nФорма: {5}\nСплав: {6}\nГурт: {7}\nТема: {8}\n"
                , Country, Type, Year, Value, CurrencyUnit, Shape, Composition, Edge, Subject);
            return sb.ToString();
        }

        public Coin()
        {
            Country = null;
            Type = null;
            Year = null;
            Value = null;
            CurrencyUnit = null;
            Shape = null;
            Composition = null;
            Edge = null;
            Subject = null;
    }

        public Coin(XmlNode node)
        {
            Country = node.ParentNode.Attributes.GetNamedItem("Name").Value;
            Type = node.Attributes.GetNamedItem("Type").Value;
            Year = node.Attributes.GetNamedItem("Year").Value;
            Value = node.Attributes.GetNamedItem("Value").Value;
            CurrencyUnit = node.Attributes.GetNamedItem("CurrencyUnit").Value;
            Shape = node.Attributes.GetNamedItem("Shape").Value;
            Composition = node.Attributes.GetNamedItem("Composition").Value;
            Edge = node.Attributes.GetNamedItem("Edge").Value;
            Subject = node.Attributes.GetNamedItem("Subject").Value;
        }

        public Coin(XElement node)
        {
            Country = node.Parent.Attribute("Name").Value;
            Type = node.Attribute("Type").Value;
            Year = node.Attribute("Year").Value;
            Value = node.Attribute("Value").Value;
            CurrencyUnit = node.Attribute("CurrencyUnit").Value;
            Shape = node.Attribute("Shape").Value;
            Composition = node.Attribute("Composition").Value;
            Edge = node.Attribute("Edge").Value;
            Subject = node.Attribute("Subject").Value;
        }
    }
}
