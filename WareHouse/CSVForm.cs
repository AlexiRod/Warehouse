using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WareHouse
{
    public partial class CSVForm : Form
    {
        public CSVForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                int count = (int)nudCount.Value;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV-файл(*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string file = saveFileDialog.FileName;
                List<Section> sections = StoreForm.GetList();
                List<CsvRow> wares = new List<CsvRow>();

                foreach (var section in sections)
                {
                    List<string> path = new List<string>();
                    GetPath(path, section);

                    foreach (var ware in section.Wares)
                        if (ware.Count < count)
                            wares.Add(new CsvRow(string.Join(" / ", path), ware.Name, ware.Articule, ware.Count.ToString()));
                }
                using (StreamWriter streamWriter = new StreamWriter(file))
                {
                    using (CsvWriter csvWriter = new CsvWriter(streamWriter, CultureInfo.CurrentCulture))
                    {
                        csvWriter.WriteRecords(wares);
                    }
                }

                MessageBox.Show("CSV-отчет успешно создан.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void GetPath(List<string> path, Section section)
        {
            try
            {
                if (section == null)
                    return;
                GetPath(path, StoreForm.GetParent(section));
                path.Add(section.Name);

            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class CsvRow
    {
        public CsvRow(string path, string name, string articule, string count)
        {
            Path = path;
            Name = name;
            Articule = articule;
            Count = count;
        }

        public string Path { get; set; }
        public string Name { get; set; }
        public string Articule { get; set; }
        public string Count { get; set; }
    }
}
