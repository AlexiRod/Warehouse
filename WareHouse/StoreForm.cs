using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WareHouse.Properties;

namespace WareHouse
{
    public partial class StoreForm : Form
    {
        private static Random random = new Random();
        private static XmlSerializer formatter = new XmlSerializer(typeof(List<Section>), new Type[] { typeof(Ware) });
        public static string pathToXmlFile = "";

        private static List<Section> sections = new List<Section>();
        private static Dictionary<DataGridViewRow, Ware> wares = new Dictionary<DataGridViewRow, Ware>();
        private static Section mainSection = null;
        public Section currentSection = null;
        public Ware currentWare = null;

        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            treeView.TreeViewNodeSorter = new CodeSorter();
            treeView.ImageList = new ImageList() { Images = { Resources.folder1, Resources.folder2 } };
            itemChooseFile.Click += ItemChooseFile_Click;
            itemAddSection.Click += ItemAddSection_Click;
            itemEditSection.Click += ItemEditSection_Click;
            itemDeleteSection.Click += ItemDeleteSection_Click;
            itemGenerateRandom.Click += ItemGenerateRandom_Click;
            ItemInfo.Click += ItemInfo_Click;
            ItemAddWare.Click += ItemAddWare_Click;
            ItemEditWare.Click += ItemEditWare_Click;
            ItemDeleteWare.Click += ItemDeleteWare_Click;
            ItemCSVReport.Click += ItemCSVReport_Click;
        }









        #region TreeView

        // События контекстного меню

        /// <summary>
        /// Выбор файла данных склада.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XML-файл данных склада(*.xml)|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                dataGridView.Rows.Clear();
                dataGridViewNeighbours.Rows.Clear();
                sections = new List<Section>();
                wares = new Dictionary<DataGridViewRow, Ware>();
                mainSection = null;
                currentSection = null;
                currentWare = null;
                pathToXmlFile = openFileDialog.FileName;
                ReadSections();
                FillTreeView();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        /// <summary>
        /// Добавление раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemAddSection_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSection == null)
                    return;
                SectionForm sectionForm = new SectionForm() { Text = $"Добавление подраздела в раздел {currentSection.Name}" };
                sectionForm.ShowDialog();
                Section section = sectionForm.section;

                if (section == null)
                    return;

                sections.Add(section);
                currentSection.AddSection(section);
                WriteSections();
                FillTreeView();
                MessageBox.Show($"Раздел {section.Name} успешно создан.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменение раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemEditSection_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSection == null)
                    return;

                SectionForm sectionForm = new SectionForm(currentSection) { Text = $"Изменение раздела" };
                sectionForm.ShowDialog();

                WriteSections();
                FillTreeView();
                MessageBox.Show($"Раздел {currentSection.Name} успешно изменен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Удаление раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemDeleteSection_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSection == null)
                    return;

                DialogResult dialogResult = MessageBox.Show($"Вы точно хотите удалить раздел {currentSection.Name}?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes)
                    return;

                if (currentSection == mainSection)
                {
                    MessageBox.Show("Нельзя удалить основной раздел склада.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (currentSection.Sections.Count != 0)
                {
                    MessageBox.Show($"Раздел {currentSection.Name} содержит подразделы. Удалять раздел, содержащий подразделы нельзя. Удалите их и повторите попытку.",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sections.Remove(currentSection);
                Section parent = GetParent(currentSection);
                if (parent != null)
                    parent.Sections.Remove(currentSection);
                WriteSections();
                FillTreeView();
                MessageBox.Show($"Раздел {currentSection.Name} успешно удален.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Генерация случайных разделов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemGenerateRandom_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSection == null)
                    return;
                RandomSectionsForm randomSectionsForm = new RandomSectionsForm(currentSection);
                randomSectionsForm.ShowDialog();
                WriteSections();
                FillTreeView();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // События мыши и TreeView

        /// <summary>
        /// Нажатие мыши на дерево.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                TreeNode node = treeView.GetNodeAt(e.Location);
                if (node == null || node.Tag == null)
                    return;
                Section section = node.Tag as Section;

                foreach (var item in sections)
                    if (item.Name == section.Name)
                        currentSection = item;

                if (e.Button == MouseButtons.Right)
                    treeView.SelectedNode = node;

                currentWare = null;
                dataGridView.Rows.Clear();
                dataGridViewNeighbours.Rows.Clear();
                if (e.Button == MouseButtons.Left)
                    FillDataGridViews();

            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Наведение курсора на дерево.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip.RemoveAll();
                TreeNode node = treeView.GetNodeAt(treeView.PointToClient(Cursor.Position));

                if (node == null)
                    return;
                Section section = node.Tag as Section;
                if (section == null)
                    return;

                toolTip.SetToolTip(treeView, $"Код сортировки раздела: {section.Code}");
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Дополнительные методы для TreeView

        /// <summary>
        /// Перерисовка дерева.
        /// </summary>
        private void FillTreeView()
        {
            try
            {
                List<string> openedNodes = new List<string>();
                if (treeView.Nodes.Count != 0)
                    WorkWithExpandedNodes(treeView.Nodes[0], openedNodes);

                treeView.Nodes.Clear();
                treeView.Nodes.Add(new TreeNode(mainSection.Name) { ImageIndex = 0, SelectedImageIndex = 1, Tag = mainSection });

                foreach (var item in mainSection.Sections)
                    AddTreeNode(item, treeView.Nodes[0]);

                if (treeView.Nodes.Count != 0)
                    WorkWithExpandedNodes(treeView.Nodes[0], openedNodes, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Добавление узлов в дерево.
        /// </summary>
        /// <param name="curSection"></param>
        /// <param name="node"></param>
        private void AddTreeNode(Section curSection, TreeNode node)
        {
            try
            {
                TreeNode tNode = new TreeNode(curSection.Name) { ImageIndex = 0, SelectedImageIndex = 1, Tag = curSection };
                node.Nodes.Add(tNode);

                foreach (var section in curSection.Sections)
                    AddTreeNode(section, tNode);
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion





        #region DataGridView 

        // События контекстного меню

        /// <summary>
        /// Карточка товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentWare == null)
                    return;
                WareForm wareForm = new WareForm(currentWare, "I");
                wareForm.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Добавление товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemAddWare_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSection == null)
                    return;
                WareForm wareForm = new WareForm(null, "A", currentSection.Name);
                wareForm.ShowDialog();

                Ware ware = wareForm.ware;
                if (ware == null)
                    return;

                currentSection.Wares.Add(ware);
                WriteSections();
                FillDataGridViews();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Изменение товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemEditWare_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentWare == null)
                    return;
                WareForm wareForm = new WareForm(currentWare, "E");
                wareForm.ShowDialog();

                Ware ware = wareForm.ware;
                if (ware == null)
                    return;

                currentWare = ware;
                //selectedProduct.EditElements();
                WriteSections();
                FillDataGridViews();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Удаление товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemDeleteWare_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentSection == null || currentWare == null)
                    return;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить этот товар?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult != DialogResult.Yes)
                    return;
                currentSection.Wares.Remove(currentWare);
                WriteSections();
                FillDataGridViews();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Создание CSV-отчета.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemCSVReport_Click(object sender, EventArgs e)
        {
            try
            {
                CSVForm csvForm = new CSVForm();
                csvForm.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        // События мыши и DataGridView

        /// <summary>
        /// Нажатие мыши на таблицу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (dataGridView.CurrentCell == null)
                        return;
                    DataGridViewRow row = dataGridView.CurrentCell.OwningRow;
                    if (row == null)
                        return;
                    currentWare = wares[row];
                    row.Selected = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Дополнительные методы для DataGridView
        
        /// <summary>
        /// Перерисовка таблицы.
        /// </summary>
        private void FillDataGridViews()
        {
            try
            {
                dataGridView.Rows.Clear();
                //TextBoxOtherProducts.Text = "";
                wares.Clear();
                foreach (var ware in currentSection.Wares)
                {
                    int ind = dataGridView.Rows.Add(ware.Name, ware.Articule, ware.Price, ware.Count);
                    wares.Add(dataGridView.Rows[ind], ware);
                }
                Section parent = GetParent(currentSection);
                if (parent == null)
                    return;

                dataGridViewNeighbours.Rows.Clear();
                foreach (var section in parent.Sections)
                {
                    if (section == currentSection)
                        continue;

                    foreach (var ware in section.Wares)
                        dataGridViewNeighbours.Rows.Add(section.Name, ware.Name, ware.Articule, ware.Price, ware.Count);

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion


        #region Сериализация 

        /// <summary>
        /// Запись всех разделов, их подразделов и товаров.
        /// </summary>
        private void WriteSections()
        {
            try
            {
                if (pathToXmlFile == "")
                    return;
                File.WriteAllText(pathToXmlFile, "");
                using (FileStream fs = new FileStream(pathToXmlFile, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, sections);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Чтение и десериализация разделов
        /// </summary>
        private void ReadSections()
        {
            try
            {
                using (FileStream fs = new FileStream(pathToXmlFile, FileMode.OpenOrCreate))
                {
                    sections = (List<Section>)formatter.Deserialize(fs);
                }
                if (sections.Count != 0)
                    mainSection = sections[0];

                // Так как сериализация не сохраняет ссылки на подразделы у разделов, приходится делать так
                foreach (var childSection in sections)
                {
                    foreach (var parentSection in sections)
                    {
                        if (parentSection.ContainsSection(childSection.Name))
                        {
                            parentSection.RemoveSection(childSection);
                            parentSection.AddSection(childSection);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Закрытие формы и сохранение склада.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteSections();
        }

        #endregion


        #region Дополнительные методы

        /// <summary>
        /// Проверка на то, есть ли раздел в дереве.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool SectionExists(string name)
        {
            return ContainsSection(name, sections);
        }

        /// <summary>
        /// Проверка на то, есть ли раздел в конкретном списке.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool ContainsSection(string name, List<Section> list)
        {
            try
            {
                foreach (var section in list)
                    if (section.Name == name)
                        return true;
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Проверка на то, есть ли товар.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool WareExists(string name)
        {
            try
            {
                foreach (var ware in wares.Values)
                    if (ware.Name == name)
                        return true;
                return false;
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Получение раздела по имени.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Section GetSection(string name)
        {
            try
            {
                foreach (var section in sections)
                    if (section.Name == name)
                        return section;
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Получение родителя раздела.
        /// </summary>
        /// <param name="childSection"></param>
        /// <returns></returns>
        public static Section GetParent(Section childSection)
        {
            try
            {
                foreach (var section in sections)
                    foreach (var sec in section.Sections)
                        if (sec.Name == childSection.Name)
                            return section;
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Статический метод получения списка для других форм.
        /// </summary>
        /// <returns></returns>
        public static List<Section> GetList()
        {
            return sections;
        }

        /// <summary>
        /// Сохранение данных об открытых и закрытых разделах и последующее раскрытие нужных.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="list"></param>
        /// <param name="doExpand"></param>
        private void WorkWithExpandedNodes(TreeNode node, List<string> list, bool doExpand = false)
        {
            try
            {
                if (!doExpand)
                {
                    if (node.IsExpanded)
                        list.Add(node.Text);
                    foreach (TreeNode item in node.Nodes)
                        WorkWithExpandedNodes(item, list);
                }
                else
                {
                    if (list.Contains(node.Text))
                        node.Toggle();
                    foreach (TreeNode item in node.Nodes)
                        WorkWithExpandedNodes(item, list, true);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("При работе программы произошла ошибка! Текст ошибки: " + exception.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Справка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для работы с программой кликните правой кнопкой мыши по левой части экрана и выберите Xml-файл с данными склада (пример такого файла есть в папке с исполняемым модулем). Если такого нет, шаблон с пустым складом также есть в папке исполняемого модуля. Работа с деревом и таблицей товаров осуществляется через контекстное меню - кликните сначала по узлу дерева или ряду таблицы (в верхней правой части формы) левой, а затем правой кнопкой мыши и в предложенном меню выберите интересующий функционал.", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


    }

    /// <summary>
    /// Класс с методом для кода сортировки разделов.
    /// </summary>
    public class CodeSorter : IComparer
    {
        /// <summary>
        /// Метод сравнения двух разделов сначала по коду сортировки, а затем по имени.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public int Compare(object l, object r)
        {
            try
            {
                Section leftSection = StoreForm.GetSection((l as TreeNode).Text);
                Section rightSection = StoreForm.GetSection((r as TreeNode).Text);
                if (leftSection == null || rightSection == null)
                    return 0;

                if (leftSection.Code.CompareTo(rightSection.Code) == 0)
                    return leftSection.Name.CompareTo(rightSection.Name);
                else
                    return leftSection.Code.CompareTo(rightSection.Code);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }

}
//Ware w1 = new Ware("w1", "12344", 12.5, 32);
//Ware w2 = new Ware("w2", "8764", 54.6, 21);
//Section mainSection = new Section("sorage");
//Section section1 = new Section("s1");
//Section section2 = new Section("s2");
//Section section3 = new Section("s3");
//section1.AddWare(w1);
//section1.AddWare(w2);
//section2.AddSection(section3);
//sections.Add(mainSection);
//sections.Add(section1);
//sections.Add(section2);
//sections.Add(section3);
//mainSection.AddSection(section1);
//mainSection.AddSection(section2);
//WriteSections();


/*
<?xml version="1.0"?>
<ArrayOfSection xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Section>
    <Name>sorage</Name>
    <Code>0</Code>
    <Sections>
      <Section>
        <Name>s1</Name>
        <Code>0</Code>
        <Sections />
        <Wares>
          <Ware>
            <Name>w1</Name>
            <Articule>12344</Articule>
            <Price>12.5</Price>
            <Count>32</Count>
          </Ware>
          <Ware>
            <Name>w2</Name>
            <Articule>8764</Articule>
            <Price>54.6</Price>
            <Count>21</Count>
          </Ware>
        </Wares>
      </Section>
      <Section>
        <Name>s2</Name>
        <Code>0</Code>
        <Sections>
          <Section>
            <Name>s3</Name>
            <Code>0</Code>
            <Sections />
            <Wares />
          </Section>
        </Sections>
        <Wares />
      </Section>
    </Sections>
    <Wares />
  </Section>
  <Section>
    <Name>s1</Name>
    <Code>0</Code>
    <Sections />
    <Wares>
      <Ware>
        <Name>w1</Name>
        <Articule>12344</Articule>
        <Price>12.5</Price>
        <Count>32</Count>
      </Ware>
      <Ware>
        <Name>w2</Name>
        <Articule>8764</Articule>
        <Price>54.6</Price>
        <Count>21</Count>
      </Ware>
    </Wares>
  </Section>
  <Section>
    <Name>s2</Name>
    <Code>0</Code>
    <Sections>
      <Section>
        <Name>s3</Name>
        <Code>0</Code>
        <Sections />
        <Wares />
      </Section>
    </Sections>
    <Wares />
  </Section>
  <Section>
    <Name>s3</Name>
    <Code>0</Code>
    <Sections />
    <Wares />
  </Section>
</ArrayOfSection>
 
 */