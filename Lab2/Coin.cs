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
        // Список атрибутів
        internal static List<string> Keys = new List<string>();

        // Пари атрибут - значення
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();

        public Dictionary<string, string> Attributes { get { return _attributes; } set { _attributes = value; } }

        // Рядок для відображення в формі
        public override string ToString()
        {
            string s = "";

            foreach (var item in Attributes)
            {
                s += item.Key + ": " + item.Value + "\n";
            }

            return s;
        }

        // Конструктор установлює словник відповідно
        // до списку атрибутів
        public Coin()
        {
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

        // Оператор "не дорівнює"
        public static bool operator !=(Coin filter, Coin coin)
        {
            foreach (var val in filter.Attributes)
            {
                if (val.Value != null && (coin.Attributes[val.Key] == null || val.Value != coin.Attributes[val.Key]))
                    return true;
            }
            return false;
        }

        // Оператор "дорівнює"
        public static bool operator ==(Coin coin1, Coin coin2)
        {
            return !(coin1 != coin2);
        }
    }
}
