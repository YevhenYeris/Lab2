using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml;
using System.Xml.Linq;

namespace Lab2
{
    class Coin
    {
        internal static List<string> Keys = new List<string>();

        public Dictionary<string, string> Attributes = new Dictionary<string, string>();

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
            string s = "";

            /*sb.AppendFormat("Країна: {0}\nТип: {1}\nРік: {2}\nНомінал: {3}\nВалютна одиниця: {4}\nФорма: {5}\nСплав: {6}\nГурт: {7}\nТема: {8}\n"
                , Country, Type, Year, Value, CurrencyUnit, Shape, Composition, Edge, Subject);*/

            foreach (var item in Attributes)
            {
                s += item.Key + ": " + item.Value + "\n";
            }

            return s;
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

            /*Attributes.Add("Country", null);
            Attributes.Add("Type", null);
            Attributes.Add("Year", null);
            Attributes.Add("Value", null);
            Attributes.Add("CurrencyUnit", null);
            Attributes.Add("Shape", null);
            Attributes.Add("Composition", null);
            Attributes.Add("Edge", null);
            Attributes.Add("Subject", null);*/

            foreach (string item in Keys)
            {
                if (!Attributes.ContainsKey(item))
                {
                    Attributes.Add(item, null);
                }
            }
        }

        public Coin(XmlNode node, string country)
        {
            Country = node.ParentNode.Attributes.GetNamedItem("ID").Value;
            //Attributes["Country"] = node.ParentNode.Attributes.GetNamedItem("ID").Value;
            Type = node.Attributes.GetNamedItem("Type").Value;
            //Attributes["Type"] = node.Attributes.GetNamedItem("Type").Value;
            Year = node.Attributes.GetNamedItem("Year").Value;
            //Attributes["Year"] = node.Attributes.GetNamedItem("Year").Value;
            Value = node.Attributes.GetNamedItem("Value").Value;
            //Attributes["Value"] = node.Attributes.GetNamedItem("Value").Value;
            CurrencyUnit = node.Attributes.GetNamedItem("CurrencyUnit").Value;
            //Attributes["CurrencyUnit"] = node.Attributes.GetNamedItem("CurrencyUnit").Value;
            Shape = node.Attributes.GetNamedItem("Shape").Value;
            //Attributes["Value"] = node.Attributes.GetNamedItem("Shape").Value;
            Composition = node.Attributes.GetNamedItem("Composition").Value;
            //Attributes["Composition"] = node.Attributes.GetNamedItem("Composition").Value;
            Edge = node.Attributes.GetNamedItem("Edge").Value;
            //Attributes["Edge"] = node.Attributes.GetNamedItem("Edge").Value;
            Subject = node.Attributes.GetNamedItem("Subject").Value;
            //Attributes["Subject"] = node.Attributes.GetNamedItem("Subject").Value;

            Attributes["Country"] = country;

            foreach (string item in Keys)
            {
                if (!Attributes.ContainsKey(item))
                {
                    Attributes.Add(item, null);
                }

                if (node.Attributes.GetNamedItem(item) != null)
                {
                    Attributes[item] = node.Attributes.GetNamedItem(item).Value;
                }
            }
        }

        public Coin(XElement node, string country)
        {
            //Country = node.Parent.Attribute("ID").Value;
            //Attributes["Country"] = node.Parent.Attribute("ID").Value;
            //Type = node.Attribute("Type").Value;
            //Attributes["Type"] = node.Attribute("Type").Value;
            //Year = node.Attribute("Year").Value;
            //Attributes["Year"] = node.Attribute("Year").Value;
            //Value = node.Attribute("Value").Value;
            //Attributes["Value"] = node.Attribute("Value").Value;
            //CurrencyUnit = node.Attribute("CurrencyUnit").Value;
            //Attributes["CurrencyUnit"] = node.Attribute("CurrencyUnit").Value;
            //Shape = node.Attribute("Shape").Value;
            //Attributes["Shape"] = node.Attribute("Shape").Value;
            //Composition = node.Attribute("Composition").Value;
            //Attributes["Composition"] = node.Attribute("Composition").Value;
            //Edge = node.Attribute("Edge").Value;
            //Attributes["Edge"] = node.Attribute("Edge").Value;
            //Subject = node.Attribute("Subject").Value;
            //Attributes["Subject"] = node.Attribute("Subject").Value;

            Attributes["Country"] = country;

            foreach (string item in Keys)
            {
                if (!Attributes.ContainsKey(item))
                {
                    Attributes.Add(item, null);
                }

                if (node.Attribute(item) != null)
                {
                    Attributes[item] = node.Attribute(item).Value;
                }
            }
        }

        public static bool operator !=(Coin filter, Coin coin)
        {
            foreach (var val in filter.Attributes)
            {
                if (val.Value != null && (coin.Attributes[val.Key] == null || val.Value != coin.Attributes[val.Key]))
                    return true;
            }
            return false;
        }

        public static bool operator ==(Coin coin1, Coin coin2)
        {
            return !(coin1 != coin2);
        }
    }
}
