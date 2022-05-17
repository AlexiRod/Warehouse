namespace WareHouse
{
    partial class CSVForm
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
            this.lblCSV = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCSV
            // 
            this.lblCSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCSV.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCSV.Location = new System.Drawing.Point(0, 0);
            this.lblCSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(504, 90);
            this.lblCSV.TabIndex = 0;
            this.lblCSV.Text = "Генерация CSV-отчета";
            this.lblCSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(281, 96);
            this.nudCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(212, 35);
            this.nudCount.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(15, 99);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(260, 27);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Количество для дозаказа:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(20, 157);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(472, 66);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Создать отчет";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // CSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 241);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.lblCSV);
            this.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CSVForm";
            this.Text = "CSVForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCSV;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnAccept;
    }
}