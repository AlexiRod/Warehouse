namespace WareHouse
{
    partial class WareForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWare = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblArticule = new System.Windows.Forms.Label();
            this.tbArticule = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWare
            // 
            this.lblWare.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWare.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWare.Location = new System.Drawing.Point(0, 0);
            this.lblWare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWare.Name = "lblWare";
            this.lblWare.Size = new System.Drawing.Size(960, 90);
            this.lblWare.TabIndex = 0;
            this.lblWare.Text = "Продукт";
            this.lblWare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 27);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Название:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(128, 95);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(366, 35);
            this.tbName.TabIndex = 1;
            // 
            // lblArticule
            // 
            this.lblArticule.AutoSize = true;
            this.lblArticule.Location = new System.Drawing.Point(16, 139);
            this.lblArticule.Name = "lblArticule";
            this.lblArticule.Size = new System.Drawing.Size(95, 27);
            this.lblArticule.TabIndex = 1;
            this.lblArticule.Text = "Артикул:";
            // 
            // tbArticule
            // 
            this.tbArticule.Location = new System.Drawing.Point(128, 136);
            this.tbArticule.Name = "tbArticule";
            this.tbArticule.Size = new System.Drawing.Size(366, 35);
            this.tbArticule.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(169, 27);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Цена (в усл. ед.):";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(194, 177);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(300, 35);
            this.nudPrice.TabIndex = 3;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(248, 218);
            this.nudCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(246, 35);
            this.nudCount.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(16, 221);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(226, 27);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Количество на складе:";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(516, 123);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(430, 430);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(17, 262);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(207, 27);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Текстовое описание:";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(17, 297);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(476, 318);
            this.tbText.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(516, 569);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(212, 46);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(734, 569);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(212, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(516, 93);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(146, 27);
            this.lblImage.TabIndex = 2;
            this.lblImage.Text = "Изображение:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(872, 9);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 75);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // WareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 627);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbArticule);
            this.Controls.Add(this.lblArticule);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWare);
            this.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "WareForm";
            this.Text = "Карточка продукта";
            this.Load += new System.EventHandler(this.WareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWare;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblArticule;
        private System.Windows.Forms.TextBox tbArticule;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnAccept;
    }
}