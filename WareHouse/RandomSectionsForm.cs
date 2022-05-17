using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WareHouse
{
    public partial class RandomSectionsForm : Form
    {
        public Section section;
        public List<Section> sections;
        private static Random random = new Random();

        public RandomSectionsForm(Section section)
        {
            InitializeComponent();
            this.section = section;
            this.sections = StoreForm.GetList();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudMinSections.Value > nudMaxSections.Value || nudMinWares.Value > nudMaxWares.Value)
                {
                    MessageBox.Show("Минимальное число должно быть больше или равно максимальному", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (section == null)
                    return;

                int generatedSections = random.Next((int)nudMinSections.Value, (int)nudMaxSections.Value + 1);
                for (int i = 0; i < generatedSections; i++)
                {
                    Section generatedSection = new Section(MakeRandomWord("Section"), random.Next(0, 11));

                    int generatedWares = random.Next((int)nudMinWares.Value, (int)nudMaxWares.Value + 1);
                    for (int j = 0; j < generatedWares; j++)
                    {
                        string name = MakeRandomWord("Ware");
                        string articule = MakeRandomWord("Articule");
                        double price = random.NextDouble() + random.Next(10, 10001);
                        int count = random.Next(1, 1001);
                        string text = MakeRandomWord("Text");
                        generatedSection.Wares.Add(new Ware(name, articule, price, count, text, ""));
                    }

                    sections.Add(generatedSection);
                    section.AddSection(generatedSection);
                }

                MessageBox.Show($"В разделе {section.Name} сгенерировано {generatedSections} подразделов со случайными товарами.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string MakeRandomWord(string word)
        {
            return word + "_" + random.Next(0, 101).ToString() + "_" + DateTime.Now.ToString();
        }
    }
}
