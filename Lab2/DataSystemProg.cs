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
    class DataSystemProg
    {
        internal const string XmlFile = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/Resources/XmlCollectionCountries.xml";
        internal const string XmlResFile = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/Resources/ResultXml.xml";
        internal const string XsltFile = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/Resources/XSLTFile1.xslt";
        internal const string HtmlFile = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/Resources/HTMLCollection.html";

        private Coin _filter = new Coin();

        private List<Coin> _found = new List<Coin>();

        internal Coin Filter {
            get { return _filter; }
            set { _filter = value; } }

        public DataSystemProg() : base()
        {
            setAttributes();
        }

        internal void setAttributes()
        {
            List<string> tempAttrs = new List<string>(); // Список атрибутів

            XmlDocument doc = new XmlDocument();
            doc.Load(DataSystemProg.XmlFile);

            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList nodes = xRoot.SelectNodes("Country");

            tempAttrs.Add("Country");

            foreach (XmlNode node in nodes)
            {
                XmlNodeList coins = node.SelectNodes("Coin");

                foreach (XmlNode coin in coins)
                {
                    foreach (XmlAttribute attr in coin.Attributes)
                    {
                        if (!tempAttrs.Contains(attr.Name))
                        {
                            tempAttrs.Add(attr.Name);
                        }
                    }
                }

                foreach (string item in tempAttrs)
                {
                    Coin.Keys.Add(item);
                }
                _filter = new Coin();
            }

        }

        // Знайти елементи, відповідно до заданих параметрів у _filter
        internal List<Coin> Search(IXmlSearchStrategy strategy)
        {
            _found = strategy.FindCoins(_filter);

            XmlMaker maker = new XmlMaker();
            maker.BuildXml(_found);

            return _found;
        }

        // Конвертувати файл xml у html
        internal void ToHtml()
        {
            XslCompiledTransform xslCompiled = new XslCompiledTransform();
            xslCompiled.Load(XsltFile);

            string inXml = XmlResFile;
            string outHtml = HtmlFile;

            xslCompiled.Transform(inXml, outHtml);
        }

        // Створити xml-файл за результатами пошуку
        
    }
}
