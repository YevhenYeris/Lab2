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

namespace Lab2
{
    public partial class CoinCollectionForm : Form
    {
        DataSystemProg prog = new DataSystemProg();

        public CoinCollectionForm()
        {
            InitializeComponent();

            setFilter();
        }

        #region Пошук і виведення

        // Установлення рядків у таблиці параметрів пошуку
        private void setFilter()
        {
            FilterSetter setter = new FilterSetter();

            dataGrid.Rows.AddRange(setter.makeRows());
        }

        // Скидання фільтрів 
        private void resetFilter()
        {
            richTextBox1.Text = "";

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                DataGridViewComboBoxCell cellCombo = row.Cells[0] as DataGridViewComboBoxCell;
                cellCombo.Value = null;
            }
        }

        // Установлення фільтру згідно до обраних параметрів
        private void setFilterCoin()
        {
            Coin coin = new Coin();

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                DataGridViewComboBoxCell cell = row.Cells[0] as DataGridViewComboBoxCell;

                if (cell.Value != null)
                    coin.Attributes[row.Cells[1].Value.ToString()] = cell.Value.ToString();
            }
            prog.Filter = coin;
        }

        // Виведення тексту в RichTextBox
        private void setRichTextBox(IEnumerable list)
        {
            richTextBox1.Clear();

            foreach (var coin in list)
            {
                richTextBox1.Text += coin.ToString() + "\n";
            }
        }

        #endregion

        #region Обробка кліків

        // Пошук даних
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

        // Скидання фільтрів
        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetFilter();
        }

        // Трансформація в html
        private void buttonHtml_Click(object sender, EventArgs e)
        {
            prog.ToHtml();
        }

        // Виведення інформації
        private void buttonINFO_Click(object sender, EventArgs e)
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Виконав Єріс Євген, група К-25\n");
            info.AppendLine("Інформаційна система: колекція монет\n");
            info.AppendLine("Структура системи: -Колекція");
            info.AppendLine("--Країна");
            info.AppendLine("---Монета");
            info.AppendLine("----Тип");
            info.AppendLine("----Рік");
            info.AppendLine("----Номінал");
            info.AppendLine("----Валютна одиниця");
            info.AppendLine("----Форма");
            info.AppendLine("----Сплав");
            info.AppendLine("----Гурт");
            info.AppendLine("----Тема\n");
            info.AppendLine("У Html-файл записуються результати пошуку\n");
            info.AppendLine("Пошук реалізовано трьома способами:\nDOM, SAX, Linq to Html");

            MessageBox.Show(info.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (AskExit() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool AskExit()
        {
            const string message = "Ви дійсно бажаєте закрити програму?";
            const string caption = "Закрити програму";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
    }
}