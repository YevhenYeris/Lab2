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
using System.Collections;
using System.Reflection.Metadata.Ecma335;

/*TODOs
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
    public partial class Form1 : Form
    {
        DataSystemProg prog = new DataSystemProg();

        List<ComboBox> comboBoxes = new List<ComboBox>();

        public Form1()
        {
            InitializeComponent();
            /*comboBoxes = new List<ComboBox>(new ComboBox[] { comboBoxCountry, comboBoxType, comboBoxComposition,
            comboBoxCurrency, comboBoxTheme, comboBoxValue, comboBoxEdge, comboBoxShape, comboBoxYear});*/

            setFilter();
        }

        // Set items in ComboBoxes
        private void setFilter()
        {
            dataGrid.Rows.AddRange(prog.makeRows());
        }

        // Add item to ComboBox
        private void addItem(XmlNode coin)
        {
            /*if (coin.Attributes.GetNamedItem("CurrencyUnit") != null && !comboBoxCurrency.Items.Contains(coin.Attributes.GetNamedItem("CurrencyUnit").Value))
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
                comboBoxTheme.Items.Add(coin.Attributes.GetNamedItem("Subject").Value);*/
        }

        // Set ComboBoxes default TODO 
        private void resetFilter()
        {
            richTextBox1.Text = "";
            for (int i = 0; i < comboBoxes.Count; ++i)
            {
                comboBoxes[i].SelectedItem = null;
                comboBoxes[i].Text = "Усі";
            }

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                cell.Value = false;

                DataGridViewComboBoxCell cellCombo = row.Cells[1] as DataGridViewComboBoxCell;
                cellCombo.Value = "";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Coin> found = new List<Coin>();

            setFilterCoin();

            if (radioButtonDOM.Checked)
            {
                found = prog.Search(new DOM());
            }
            if (radioButtonSAX.Checked)
            {
                found = prog.Search(new SAX());
            }
            if (radioButtonLINQ.Checked)
            {
                found = prog.Search(new LinqToXml());
            }

            setRichTextBox(found);
        }

        private void setFilterCoin()
        {
            Coin coin = new Coin();

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                DataGridViewComboBoxCell cell = row.Cells[1] as DataGridViewComboBoxCell;
                DataGridViewCheckBoxCell cellCheck = row.Cells[0] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellCheck.Value) && cell.Value != null)
                    coin.Attributes[row.Cells[2].Value.ToString()] = cell.Value.ToString();
            }
            prog.Filter = coin;
        }

        private void setRichTextBox(IEnumerable list)
        {
            richTextBox1.Clear();

            foreach (var coin in list)
            {
                richTextBox1.Text += coin.ToString() + "\n";
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prog.SetCountry((string)comboBoxCountry.SelectedItem);
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prog.SetYear((string)comboBoxYear.SelectedItem);
        }

        private void comboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prog.SetValue((string)comboBoxValue.SelectedItem);
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prog.SetCurrencyUnit((string)comboBoxCurrency.SelectedItem);
        }

        private void comboBoxEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prog.SetEdge((string)comboBoxEdge.SelectedItem);
        }

        private void comboBoxComposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prog.SetComposition((string)comboBoxComposition.SelectedItem);
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
           // prog.SetSubject((string)comboBoxTheme.SelectedItem);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*prog.SetType((string)comboBoxType.SelectedItem);

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
            }*/
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e) 
        {
            //prog.SetShape((string)comboBoxShape.SelectedItem);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetFilter();
        }

        private void buttonToHtml_Click(object sender, EventArgs e)
        {
            prog.ToHtml();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}