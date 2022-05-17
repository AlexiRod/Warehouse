
namespace WareHouse
{
    partial class StoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sCon1 = new System.Windows.Forms.SplitContainer();
            this.btnHelp = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.cmsTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemChooseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemAddSection = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEditSection = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeleteSection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.itemGenerateRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.sCon2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArticule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemAddWare = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemEditWare = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDeleteWare = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ItemCSVReport = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewNeighbours = new System.Windows.Forms.DataGridView();
            this.ColumnNeiSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNeiName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNeiArticule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNeiPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNeiCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sCon1)).BeginInit();
            this.sCon1.Panel1.SuspendLayout();
            this.sCon1.Panel2.SuspendLayout();
            this.sCon1.SuspendLayout();
            this.cmsTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCon2)).BeginInit();
            this.sCon2.Panel1.SuspendLayout();
            this.sCon2.Panel2.SuspendLayout();
            this.sCon2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.cmsDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeighbours)).BeginInit();
            this.SuspendLayout();
            // 
            // sCon1
            // 
            this.sCon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCon1.Location = new System.Drawing.Point(0, 0);
            this.sCon1.Margin = new System.Windows.Forms.Padding(4);
            this.sCon1.Name = "sCon1";
            // 
            // sCon1.Panel1
            // 
            this.sCon1.Panel1.Controls.Add(this.btnHelp);
            this.sCon1.Panel1.Controls.Add(this.treeView);
            // 
            // sCon1.Panel2
            // 
            this.sCon1.Panel2.Controls.Add(this.sCon2);
            this.sCon1.Size = new System.Drawing.Size(1271, 713);
            this.sCon1.SplitterDistance = 477;
            this.sCon1.SplitterWidth = 5;
            this.sCon1.TabIndex = 0;
            this.sCon1.Text = "splitContainer1";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 658);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(40, 40);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.cmsTreeView;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(477, 713);
            this.treeView.TabIndex = 0;
            this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
            this.treeView.MouseHover += new System.EventHandler(this.treeView_MouseHover);
            // 
            // cmsTreeView
            // 
            this.cmsTreeView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemChooseFile,
            this.toolStripSeparator3,
            this.itemAddSection,
            this.itemEditSection,
            this.itemDeleteSection,
            this.toolStripSeparator4,
            this.itemGenerateRandom});
            this.cmsTreeView.Name = "cmsTreeView";
            this.cmsTreeView.Size = new System.Drawing.Size(248, 136);
            // 
            // itemChooseFile
            // 
            this.itemChooseFile.Name = "itemChooseFile";
            this.itemChooseFile.Size = new System.Drawing.Size(247, 24);
            this.itemChooseFile.Text = "Выбрать файл данных";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(244, 6);
            // 
            // itemAddSection
            // 
            this.itemAddSection.Name = "itemAddSection";
            this.itemAddSection.Size = new System.Drawing.Size(247, 24);
            this.itemAddSection.Text = "Добавить раздел";
            // 
            // itemEditSection
            // 
            this.itemEditSection.Name = "itemEditSection";
            this.itemEditSection.Size = new System.Drawing.Size(247, 24);
            this.itemEditSection.Text = "Изменить раздел";
            // 
            // itemDeleteSection
            // 
            this.itemDeleteSection.Name = "itemDeleteSection";
            this.itemDeleteSection.Size = new System.Drawing.Size(247, 24);
            this.itemDeleteSection.Text = "Удалить раздел";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(244, 6);
            // 
            // itemGenerateRandom
            // 
            this.itemGenerateRandom.Name = "itemGenerateRandom";
            this.itemGenerateRandom.Size = new System.Drawing.Size(247, 24);
            this.itemGenerateRandom.Text = "Сгенерировать разделы";
            // 
            // sCon2
            // 
            this.sCon2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCon2.Location = new System.Drawing.Point(0, 0);
            this.sCon2.Name = "sCon2";
            this.sCon2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCon2.Panel1
            // 
            this.sCon2.Panel1.Controls.Add(this.dataGridView);
            this.sCon2.Panel1.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // sCon2.Panel2
            // 
            this.sCon2.Panel2.Controls.Add(this.dataGridViewNeighbours);
            this.sCon2.Panel2.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sCon2.Size = new System.Drawing.Size(789, 713);
            this.sCon2.SplitterDistance = 409;
            this.sCon2.TabIndex = 0;
            this.sCon2.Text = "splitContainer1";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnArticule,
            this.ColumnPrice,
            this.ColumnCount});
            this.dataGridView.ContextMenuStrip = this.cmsDataGridView;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(789, 409);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Text = "dataGridView1";
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseDown);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название услуги/товара";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnName.Width = 250;
            // 
            // ColumnArticule
            // 
            this.ColumnArticule.HeaderText = "Артикул";
            this.ColumnArticule.MinimumWidth = 6;
            this.ColumnArticule.Name = "ColumnArticule";
            this.ColumnArticule.ReadOnly = true;
            this.ColumnArticule.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnArticule.Width = 130;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Цена (в усл. ед.)";
            this.ColumnPrice.MinimumWidth = 6;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPrice.Width = 160;
            // 
            // ColumnCount
            // 
            this.ColumnCount.HeaderText = "Количество на складе";
            this.ColumnCount.MinimumWidth = 6;
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            this.ColumnCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCount.Width = 195;
            // 
            // cmsDataGridView
            // 
            this.cmsDataGridView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemInfo,
            this.toolStripSeparator1,
            this.ItemAddWare,
            this.ItemEditWare,
            this.ItemDeleteWare,
            this.toolStripSeparator2,
            this.ItemCSVReport});
            this.cmsDataGridView.Name = "cmsDataGridView";
            this.cmsDataGridView.Size = new System.Drawing.Size(207, 136);
            // 
            // ItemInfo
            // 
            this.ItemInfo.Name = "ItemInfo";
            this.ItemInfo.Size = new System.Drawing.Size(206, 24);
            this.ItemInfo.Text = "Карточка товара";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // ItemAddWare
            // 
            this.ItemAddWare.Name = "ItemAddWare";
            this.ItemAddWare.Size = new System.Drawing.Size(206, 24);
            this.ItemAddWare.Text = "Добавить товар";
            // 
            // ItemEditWare
            // 
            this.ItemEditWare.Name = "ItemEditWare";
            this.ItemEditWare.Size = new System.Drawing.Size(206, 24);
            this.ItemEditWare.Text = "Изменить товар";
            // 
            // ItemDeleteWare
            // 
            this.ItemDeleteWare.Name = "ItemDeleteWare";
            this.ItemDeleteWare.Size = new System.Drawing.Size(206, 24);
            this.ItemDeleteWare.Text = "Удалить товар";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // ItemCSVReport
            // 
            this.ItemCSVReport.Name = "ItemCSVReport";
            this.ItemCSVReport.Size = new System.Drawing.Size(206, 24);
            this.ItemCSVReport.Text = "Создать CSV-отчет";
            // 
            // dataGridViewNeighbours
            // 
            this.dataGridViewNeighbours.AllowUserToAddRows = false;
            this.dataGridViewNeighbours.AllowUserToDeleteRows = false;
            this.dataGridViewNeighbours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNeighbours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNeiSection,
            this.ColumnNeiName,
            this.ColumnNeiArticule,
            this.ColumnNeiPrice,
            this.ColumnNeiCount});
            this.dataGridViewNeighbours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNeighbours.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewNeighbours.Name = "dataGridViewNeighbours";
            this.dataGridViewNeighbours.ReadOnly = true;
            this.dataGridViewNeighbours.RowHeadersWidth = 51;
            this.dataGridViewNeighbours.Size = new System.Drawing.Size(789, 300);
            this.dataGridViewNeighbours.TabIndex = 0;
            this.dataGridViewNeighbours.Text = "dataGridView2";
            // 
            // ColumnNeiSection
            // 
            this.ColumnNeiSection.HeaderText = "Соседний раздел";
            this.ColumnNeiSection.MinimumWidth = 6;
            this.ColumnNeiSection.Name = "ColumnNeiSection";
            this.ColumnNeiSection.ReadOnly = true;
            this.ColumnNeiSection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNeiSection.Width = 165;
            // 
            // ColumnNeiName
            // 
            this.ColumnNeiName.HeaderText = "Название товара";
            this.ColumnNeiName.MinimumWidth = 6;
            this.ColumnNeiName.Name = "ColumnNeiName";
            this.ColumnNeiName.ReadOnly = true;
            this.ColumnNeiName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNeiName.Width = 165;
            // 
            // ColumnNeiArticule
            // 
            this.ColumnNeiArticule.HeaderText = "Артикул";
            this.ColumnNeiArticule.MinimumWidth = 6;
            this.ColumnNeiArticule.Name = "ColumnNeiArticule";
            this.ColumnNeiArticule.ReadOnly = true;
            this.ColumnNeiArticule.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNeiArticule.Width = 120;
            // 
            // ColumnNeiPrice
            // 
            this.ColumnNeiPrice.HeaderText = "Цена";
            this.ColumnNeiPrice.MinimumWidth = 6;
            this.ColumnNeiPrice.Name = "ColumnNeiPrice";
            this.ColumnNeiPrice.ReadOnly = true;
            this.ColumnNeiPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNeiPrice.Width = 125;
            // 
            // ColumnNeiCount
            // 
            this.ColumnNeiCount.HeaderText = "Кол-во на складе";
            this.ColumnNeiCount.MinimumWidth = 6;
            this.ColumnNeiCount.Name = "ColumnNeiCount";
            this.ColumnNeiCount.ReadOnly = true;
            this.ColumnNeiCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNeiCount.Width = 160;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Название услуги/товара";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Цена (в усл. ед.)";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Width = 160;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Количество на складе";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.Width = 190;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 713);
            this.Controls.Add(this.sCon1);
            this.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "StoreForm";
            this.Text = "Управление складом";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StoreForm_FormClosing);
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.sCon1.Panel1.ResumeLayout(false);
            this.sCon1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCon1)).EndInit();
            this.sCon1.ResumeLayout(false);
            this.cmsTreeView.ResumeLayout(false);
            this.sCon2.Panel1.ResumeLayout(false);
            this.sCon2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCon2)).EndInit();
            this.sCon2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.cmsDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeighbours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sCon1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip cmsTreeView;
        private System.Windows.Forms.ToolStripMenuItem itemAddSection;
        private System.Windows.Forms.ToolStripMenuItem itemEditSection;
        private System.Windows.Forms.ToolStripMenuItem itemDeleteSection;
        private System.Windows.Forms.SplitContainer sCon2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ContextMenuStrip cmsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem ItemAddWare;
        private System.Windows.Forms.ToolStripMenuItem ItemEditWare;
        private System.Windows.Forms.ToolStripMenuItem ItemDeleteWare;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dataGridViewNeighbours;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNeiSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNeiName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNeiArticule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNeiPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNeiCount;
        private System.Windows.Forms.ToolStripMenuItem ItemInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArticule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ItemCSVReport;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ToolStripMenuItem itemChooseFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem itemGenerateRandom;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

