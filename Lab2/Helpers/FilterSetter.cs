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
    /*
     * Допоміжний клас для заповнення
     * таблиці параметрів пошуку в формі
     */

    class FilterSetter
    {
        // Створює масив рядків для таблиці параметрів форми
        internal DataGridViewRow[] makeRows()
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>(); //Список рядків

            XmlDocument doc = new XmlDocument(); //Джерело - файл інформаційної системи
            doc.Load(DataSystemProg.XmlFile);

            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList nodes = xRoot.SelectNodes("Country");
            rows.Add(getRow("Country"));

            foreach (XmlNode node in nodes)
            {
                DataGridViewComboBoxCell cell = rows[0].Cells[0] as DataGridViewComboBoxCell;
                // Клітинка зі списком

                if (!cell.Items.Contains(node.Attributes.Item(0).Value))
                    //Додаємо до списку клітинки атрибути елементу
                    cell.Items.Add(node.Attributes.Item(0).Value);

                XmlNodeList coins = node.SelectNodes("Coin");

                foreach (XmlNode coin in coins)
                {
                    foreach (XmlAttribute attr in coin.Attributes)
                    {
                        int rowIndex = findRow(attr.Name, rows);

                        if (rowIndex < 0)
                        // Якщо рядок для даного параметру не додано, додаємо
                        {
                            rows.Add(getRow(attr.Name));
                        }

                        rowIndex = findRow(attr.Name, rows); //Оновлюємо індекс на випадок, якщо додано новий рядок

                        cell = rows[rowIndex].Cells[0] as DataGridViewComboBoxCell;

                        if (!cell.Items.Contains(attr.Value))
                        // Якщо список клітинки не має даного значення, додаємо
                        {
                            cell.Items.Add(attr.Value);
                        }
                    }
                }
            }

            return rows.ToArray();
        }

        //Допоміжний метод для знаходження радку з відповідним іменем параметру пошуку
        int findRow(string name, List<DataGridViewRow> rows)
        {
            int i = 0;

            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[1].Value.ToString() == name)
                {
                    return i;
                }
                ++i;
            }
            return -1;
        }

        // Побудувати рядок для табиці параметрів форми
        private DataGridViewRow getRow(string title)
        {
            DataGridViewRow row = new DataGridViewRow();
            var comboCell = new DataGridViewComboBoxCell();
            comboCell.Sorted = true;
            var textCell = new DataGridViewTextBoxCell();
            textCell.Value = title;

            DataGridViewCell[] cells = { comboCell, textCell };
            row.Cells.AddRange(cells);

            return row;
        }
    }
}
