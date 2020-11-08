using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

/*TODOs
 * 
 * Зберігати рещультати пошуку в новому xml-файлі
 * 
 * Оновлювати ComboBoxes
 * 
 * Додати атрибут-зображення
 * 
 * Рефакторити код
 * 
 * Додати інформацію
 * 
 * Додати MessageBoxes
 * 
 */

namespace Lab2
{
    struct Filter
    {
        public bool Selected { get; set; }
        public string Title { get; set; }
        //public List<string> Param { get; set; }

        //public ComboBox CmB { get; set; }

        /*public Filter(bool selected, string title, List<string> param)
        {
            Selected = selected;
            Title = title;
            Param = param;
        }*/

        public Filter(bool selected, string title)
        {
            Selected = selected;
            Title = title;
        }
    }

    public partial class Form1 : Form
    {
        Coin filter = new Coin();

        List<ComboBox> comboBoxes = new List<ComboBox>();

        public Form1()
        {
            InitializeComponent();
            comboBoxes = new List<ComboBox>(new ComboBox[] { comboBoxCountry, comboBoxType, comboBoxComposition,
            comboBoxCurrency, comboBoxTheme, comboBoxValue, comboBoxEdge, comboBoxShape, comboBoxYear});

            setFilter();
        }

        private void setFilter()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/XMLCollectionCountries.xml");

            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList nodes = xRoot.SelectNodes("Country");

            foreach (XmlNode node in nodes)
            {
                if (!comboBoxCountry.Items.Contains(node.Attributes.Item(0).Value))
                    comboBoxCountry.Items.Add(node.Attributes.Item(0).Value);

                XmlNodeList coins = node.SelectNodes("Coin");

                foreach (XmlNode coin in coins)
                {
                    addItem(coin);
                }
            }
        }

        private void addItem(XmlNode coin)
        {
            if (coin.Attributes.GetNamedItem("CurrencyUnit") != null && !comboBoxCurrency.Items.Contains(coin.Attributes.GetNamedItem("CurrencyUnit").Value))
                comboBoxCurrency.Items.Add(coin.Attributes.GetNamedItem("CurrencyUnit").Value);

            if (coin.Attributes.GetNamedItem("Type") != null && !comboBoxType.Items.Contains(coin.Attributes.GetNamedItem("Type").Value))
                comboBoxType.Items.Add(coin.Attributes.GetNamedItem("Type").Value);

            if (coin.Attributes.GetNamedItem("Year") != null && !comboBoxYear.Items.Contains(coin.Attributes.GetNamedItem("Year").Value))
                comboBoxYear.Items.Add(coin.Attributes.GetNamedItem("Year").Value);

            if (coin.Attributes.GetNamedItem("Value") != null && !comboBoxValue.Items.Contains(coin.Attributes.GetNamedItem("Value").Value))
                comboBoxValue.Items.Add(coin.Attributes.GetNamedItem("Value").Value);

            if (coin.Attributes.GetNamedItem("Shape") != null && !comboBoxShape.Items.Contains(coin.Attributes.GetNamedItem("Shape").Value))
                comboBoxShape.Items.Add(coin.Attributes.GetNamedItem("Shape").Value);

            if (coin.Attributes.GetNamedItem("Composition") != null && !comboBoxComposition.Items.Contains(coin.Attributes.GetNamedItem("Composition").Value))
                comboBoxComposition.Items.Add(coin.Attributes.GetNamedItem("Composition").Value);

            if (coin.Attributes.GetNamedItem("Edge") != null && !comboBoxEdge.Items.Contains(coin.Attributes.GetNamedItem("Edge").Value))
                comboBoxEdge.Items.Add(coin.Attributes.GetNamedItem("Edge").Value);

            if (coin.Attributes.GetNamedItem("Subject") != null && !comboBoxTheme.Items.Contains(coin.Attributes.GetNamedItem("Subject").Value))
                comboBoxTheme.Items.Add(coin.Attributes.GetNamedItem("Subject").Value);
        }

        private void resetFilter()
        {
            richTextBox1.Text = "";
            for (int i = 0; i < comboBoxes.Count; ++i)
            {
                comboBoxes[i].SelectedItem = null;
                comboBoxes[i].Text = "Усі";
            }
        }

        /*private bool checkFilter(string parameter, XmlNode node)
        {
            string expected = null;
            string actual = node.Attributes.GetNamedItem(parameter).Value;
            bool result = true;
            /*switch (parameter)
            {
                case "Country": expected = filter.Country;
                    break;
                case "Type": expected = filter.Type;
                    break;
                case "Year": expected = filter.Year;
                    break;
                case "Value": expected = filter.Value;
                    break;
                case "CurrencyUnit": expected = filter.CurrencyUnit;
                    break;
                case "Shape": expected = filter.Shape;
                    break;
                case "Composition": expected = filter.Composition;
                    break;
                case "Edge": expected = filter.Edge;
                    break;
                case "Subject": expected = filter.Subject;
                    break;
            }
            result &= filter.Composition == null || filter.Composition == node.Attributes.GetNamedItem("Composition").Value;
            result &= filter.Type == null || filter.Type == node.Attributes.GetNamedItem("Type").Value;
            result &= filter.Year == null || filter.Year == node.Attributes.GetNamedItem("Year").Value;
            result &= filter.CurrencyUnit == null || filter.CurrencyUnit == node.Attributes.GetNamedItem("CurrencyUnit").Value;
            result &= filter.Edge == null || filter.Edge == node.Attributes.GetNamedItem("Edge").Value;
            result &= filter.Shape == null || filter.Shape == node.Attributes.GetNamedItem("Shape").Value;
            result &= filter.Value == null || filter.Value == node.Attributes.GetNamedItem("Value").Value;
            result &= filter.Subject == null || filter.Subject == node.Attributes.GetNamedItem("Subject").Value;
            return result;
        }*/

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.Type = (string)comboBoxType.SelectedItem;

            if (comboBoxType.SelectedIndex == 1)
            {
                comboBoxTheme.Show();
                labelTheme.Show();
            }
            else
            {
                comboBoxTheme.Hide();
                comboBoxTheme.SelectedItem = null;
                labelTheme.Hide();
            }
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.Shape = (string)comboBoxShape.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            List<Coin> found = new List<Coin>();

            if (radioButtonDOM.Checked)
            {
                DOM dom = new DOM();
                found = dom.FindCoins(filter);
            }
            if (radioButtonSAX.Checked)
            {
                SAX sax = new SAX();
                found = sax.FindCoins(filter);
            }
            if (radioButtonLINQ.Checked)
            {
                LinqToXml linqToXml = new LinqToXml();
                found = linqToXml.FindCoins(filter);
            }

            foreach (Coin coin in found)
            {
                richTextBox1.Text += coin.ToString() + "\n";
            }
        }

        private void comboBoxType_DropDownStyleChanged(object sender, EventArgs e)
        {
            filter.Type = (string)comboBoxType.SelectedItem;
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.Country = (string)comboBoxCountry.SelectedItem;
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.Year = (string)comboBoxYear.SelectedItem;
        }

        private void comboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.Value = (string)comboBoxValue.SelectedItem;
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.CurrencyUnit = (string)comboBoxCurrency.SelectedItem;
        }

        private void comboBoxEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.Edge = (string)comboBoxEdge.SelectedItem;
        }

        private void comboBoxComposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.Composition = (string)comboBoxComposition.SelectedItem;
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.Subject = (string)comboBoxTheme.SelectedItem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetFilter();
        }

        private void buttonToHtml_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslCompiled = new XslCompiledTransform();
            xslCompiled.Load("D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/XSLTFile1.xslt");

            string inXml = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/XmlCollectionCountries.xml";
            string outHtml = "D:/Shkola/2ndCourse/OOP/DZ/Lab2/Lab2/HTMLCollection.html";

            xslCompiled.Transform(inXml, outHtml);

            richTextBox1.Text = 
        }
    }
}
