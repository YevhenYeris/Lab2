using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using System.Windows.Forms;

namespace Lab2
{
    class DataSystemProg
    {
        internal const string XmlFile = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/XmlCollectionCountries.xml";
        internal const string XmlResFile = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/ResultXml.xml";
        internal const string XsltFile = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/XSLTFile1.xslt";
        internal const string HtmlFile = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/HTMLCollection.html";

        private Coin _filter = new Coin();

        private List<Coin> _found = new List<Coin>();

        internal Coin Filter {
            get { return _filter; }
            set { _filter = value; } }

        internal DataGridViewRow[] makeRows()
        {
            List<string> tempAttrs = new List<string>();

            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            XmlDocument doc = new XmlDocument();
            doc.Load(DataSystemProg.XmlFile);

            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList nodes = xRoot.SelectNodes("Country");
            rows.Add(getRow("Country"));
            tempAttrs.Add("Country");

            foreach (XmlNode node in nodes)
            {
                /*if (!comboBoxCountry.Items.Contains(node.Attributes.Item(0).Value))
                    comboBoxCountry.Items.Add(node.Attributes.Item(0).Value);*/

                DataGridViewComboBoxCell cell = rows[0].Cells[1] as DataGridViewComboBoxCell;

                /*if (!((ComboBox)dataGrid.Rows[0].Cells[1].Value).Items.Contains(node.Attributes.Item(0).Value))
                    ((ComboBox)dataGrid.Rows[0].Cells[1].Value).Items.Add(node.Attributes.Item(0).Value);*/

                if (!cell.Items.Contains(node.Attributes.Item(0).Value))
                    cell.Items.Add(node.Attributes.Item(0).Value);

                XmlNodeList coins = node.SelectNodes("Coin");

                foreach (XmlNode coin in coins)
                {
                    foreach (XmlAttribute attr in coin.Attributes)
                    {
                        if (!tempAttrs.Contains(attr.Name))
                        {
                            tempAttrs.Add(attr.Name);
                            rows.Add(getRow(attr.Name));
                        }
                        int i = findRow(attr.Name, rows);
                        if (i > 0)
                        {
                            cell = rows[i].Cells[1] as DataGridViewComboBoxCell;
                            if (!cell.Items.Contains(attr.Value))
                            {
                                cell.Items.Add(attr.Value);
                            }
                        }
                    }
                    //addItem(coin);

                    foreach (string item in tempAttrs)
                    {
                        Coin.Keys.Add(item);
                    }
                    _filter = new Coin();
                }
            }

            return rows.ToArray();
        }

        int findRow(string name, List<DataGridViewRow> rows)
        {
            int i = 0;

            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[2].Value.ToString() == name)
                {
                    return i;
                }
                ++i;
            }
            return -1;
        }

        private DataGridViewRow getRow(string title)
        {
            DataGridViewRow row = new DataGridViewRow();
            var checkCell = new DataGridViewCheckBoxCell();
            var comboCell = new DataGridViewComboBoxCell();
            comboCell.Sorted = true;
            var textCell = new DataGridViewTextBoxCell();
            textCell.Value = title;
            DataGridViewCell[] cells = { checkCell, comboCell, textCell };
            row.Cells.AddRange(cells);

            return row;
        }

        internal List<Coin> Search(IXmlSearchStrategy strategy)
        {
            _found = strategy.FindCoins(_filter);
            BuildXml();
            return _found;
        }

        internal void ToHtml()
        {
            XslCompiledTransform xslCompiled = new XslCompiledTransform();
            xslCompiled.Load(XsltFile);

            string inXml = XmlResFile;
            string outHtml = HtmlFile;

            xslCompiled.Transform(inXml, outHtml);
        }

        internal void BuildXml()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));

            XmlElement root = xmlDoc.CreateElement("Collection");
            xmlDoc.AppendChild(root);
            List<XmlElement> elements = new List<XmlElement>();

            foreach (Coin coin in _found)
            {
                XmlElement countryelmt;

                if (xmlDoc.GetElementsByTagName(coin.Country) != null)
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


            xmlDoc.Save(XmlResFile);
        }

        private XmlAttribute makeAttribute(XmlDocument doc, string tag, string value)
        {
            XmlAttribute attr = doc.CreateAttribute(tag);
            attr.Value = value;

            return attr;
        }

        private XmlElement makeCoinElement(XmlDocument doc, Coin coin)
        {

            XmlElement coinelmt;

            coinelmt = doc.CreateElement("Coin");

            coinelmt.Attributes.Append(makeAttribute(doc, "Type", coin.Type));
            coinelmt.Attributes.Append(makeAttribute(doc, "Year", coin.Year));
            coinelmt.Attributes.Append(makeAttribute(doc, "Value", coin.Value));
            coinelmt.Attributes.Append(makeAttribute(doc, "CurrencyUnit", coin.CurrencyUnit));
            coinelmt.Attributes.Append(makeAttribute(doc, "Shape", coin.Shape));
            coinelmt.Attributes.Append(makeAttribute(doc, "Composition", coin.Composition));
            coinelmt.Attributes.Append(makeAttribute(doc, "Edge", coin.Edge));
            coinelmt.Attributes.Append(makeAttribute(doc, "Subject", coin.Subject));

            return coinelmt;
        }

        internal void SetCountry(string val)
        {
            _filter.Country = val;
            _filter.Attributes["Country"] = val;
        }

        internal void SetType(string val)
        {
            _filter.Type = val;
            _filter.Attributes["Type"] = val;
        }

        internal void SetYear(string val)
        {
            _filter.Year = val;
            _filter.Attributes["Year"] = val;
        }

        internal void SetValue(string val)
        {
            _filter.Value = val;
            _filter.Attributes["Value"] = val;
        }

        internal void SetCurrencyUnit(string val)
        {
            _filter.CurrencyUnit = val;
            _filter.Attributes["CurrencyUnit"] = val;
        }

        internal void SetShape(string val)
        {
            _filter.Shape = val;
            _filter.Attributes["Shape"] = val;
        }

        internal void SetComposition(string val)
        {
            _filter.Composition = val;
            _filter.Attributes["Composition"] = val;
        }

        internal void SetEdge(string val)
        {
            _filter.Edge = val;
            _filter.Attributes["Edge"] = val;
        }

        internal void SetSubject(string val)
        {
            _filter.Subject = val;
            _filter.Attributes["Subject"] = val;
        }
    }
}
