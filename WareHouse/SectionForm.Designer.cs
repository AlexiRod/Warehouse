namespace WareHouse
{
    partial class SectionForm
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
            this.lblSection = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.nudCode = new System.Windows.Forms.NumericUpDown();
            this.btnApprove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSection
            // 
            this.lblSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSection.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSection.Location = new System.Drawing.Point(0, 0);
            this.lblSection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(586, 94);
            this.lblSection.TabIndex = 0;
            this.lblSection.Text = "Раздел";
            this.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(206, 94);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(366, 35);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(187, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Название раздела:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(13, 152);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(249, 27);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Код сортировки раздела:";
            // 
            // nudCode
            // 
            this.nudCode.Location = new System.Drawing.Point(271, 149);
            this.nudCode.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCode.Name = "nudCode";
            this.nudCode.Size = new System.Drawing.Size(300, 35);
            this.nudCode.TabIndex = 3;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(13, 219);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(558, 69);
            this.btnApprove.TabIndex = 4;
            this.btnApprove.Text = "ОК";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 314);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.nudCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblSection);
            this.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SectionForm";
            this.Text = "Раздел";
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.NumericUpDown nudCode;
        private System.Windows.Forms.Button btnApprove;
    }
}