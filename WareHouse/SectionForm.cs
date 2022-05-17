using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WareHouse
{
    public partial class SectionForm : Form
    {
        public Section section = null;
        public SectionForm(Section section = null)
        {
            InitializeComponent();
            try
            {
                this.section = section;
                if (section == null)
                    lblSection.Text = "Добавление нового раздела";
                else
                {
                    lblSection.Text = $"Изменение раздела {section.Name}";
                    tbName.Text = section.Name;
                    nudCode.Value = section.Code;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text.Trim();
                int code = (int)nudCode.Value;
                if (StoreForm.SectionExists(name))
                    if (section == null || section != null && name != section.Name)
                    {
                        MessageBox.Show("Раздел с таким названием уже существует. Попробуйте другое", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        return;
                    }
                if (section == null)
                    section = new Section(name, code);
                else
                {
                    section.Name = name;
                    section.Code = code;
                }
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
