using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WareHouse
{
    public partial class WareForm : Form
    {
        public Ware ware;
        private string type = null;
        private string parentName = null;


        public WareForm(Ware ware = null, string type = null, string parentName = null)
        {
            InitializeComponent();
            this.ware = ware;
            this.type = type;
            this.parentName = parentName;
        }
        private void WareForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (ware != null)
                {
                    tbName.Text = ware.Name;
                    tbArticule.Text = ware.Articule;
                    nudPrice.Value = (decimal)ware.Price;
                    nudCount.Value = ware.Count;
                    tbText.Text = ware.Text;
                    btnDelete.Enabled = false;
                    try
                    {
                        pictureBox.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(ware.ImageString)));
                        btnDelete.Enabled = true;
                    }
                    catch (Exception)
                    {
                    }
                }

                if (type == "I")
                {
                    Text = "Информация";
                    lblWare.Text = $"Карточка товара {ware.Name}";

                    tbName.ReadOnly = true;
                    tbArticule.ReadOnly = true;
                    nudPrice.ReadOnly = true;
                    nudCount.ReadOnly = true;
                    tbText.ReadOnly = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAccept.Enabled = false;
                }
                if (type == "A")
                {
                    Text = "Добавление";
                    lblWare.Text = $"Добавление товара в {parentName}";
                }
                if (type == "F")
                {
                    Text = "Изменение";
                    lblWare.Text = $"Изменение товара {ware.Name}";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text.Trim();
                if (name == string.Empty)
                {
                    MessageBox.Show("Введите название товара", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string articule = tbArticule.Text.Trim();
                if (articule == string.Empty)
                {
                    MessageBox.Show("Введите артикул товарa", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double price = (double)nudPrice.Value;
                int count = (int)nudCount.Value;
                string text = tbText.Text;

                if (ware == null)
                    ware = new Ware(name, articule, price, count, text, ConvertImageToString(pictureBox.Image));
                else
                {
                    ware.Name = name;
                    ware.Articule = articule;
                    ware.Price = price;
                    ware.Count = count;
                    ware.Text = text;
                    ware.ImageString = ConvertImageToString(pictureBox.Image);
                }
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ConvertImageToString(Image image)
        {
            try
            {
                if (image == null)
                    return "";

                MemoryStream ms = new MemoryStream();
                image.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();

                return Convert.ToBase64String(imageBytes);
            }
            catch (Exception)
            {
                return "";
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Изображение(*.png)|*.png|Изображение(*.jpg)|*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                btnDelete.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            pictureBox.Image = null;
        }
    }
}
