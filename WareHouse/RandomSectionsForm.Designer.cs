namespace WareHouse
{
    partial class RandomSectionsForm
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
            this.lblRandom = new System.Windows.Forms.Label();
            this.lblGenerate = new System.Windows.Forms.Label();
            this.nudMinSections = new System.Windows.Forms.NumericUpDown();
            this.lblMinSections = new System.Windows.Forms.Label();
            this.nudMaxSections = new System.Windows.Forms.NumericUpDown();
            this.lblMaxSections = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxWares = new System.Windows.Forms.Label();
            this.nudMaxWares = new System.Windows.Forms.NumericUpDown();
            this.lblMinWares = new System.Windows.Forms.Label();
            this.nudMinWares = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWares)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRandom
            // 
            this.lblRandom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRandom.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRandom.Location = new System.Drawing.Point(0, 0);
            this.lblRandom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(566, 90);
            this.lblRandom.TabIndex = 0;
            this.lblRandom.Text = "Случайная генерация разделов";
            this.lblRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenerate
            // 
            this.lblGenerate.Location = new System.Drawing.Point(0, 79);
            this.lblGenerate.Name = "lblGenerate";
            this.lblGenerate.Size = new System.Drawing.Size(568, 32);
            this.lblGenerate.TabIndex = 1;
            this.lblGenerate.Text = "Число генерируемых разделов в ";
            this.lblGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMinSections
            // 
            this.nudMinSections.Location = new System.Drawing.Point(288, 133);
            this.nudMinSections.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMinSections.Name = "nudMinSections";
            this.nudMinSections.Size = new System.Drawing.Size(212, 35);
            this.nudMinSections.TabIndex = 3;
            // 
            // lblMinSections
            // 
            this.lblMinSections.AutoSize = true;
            this.lblMinSections.Location = new System.Drawing.Point(74, 135);
            this.lblMinSections.Name = "lblMinSections";
            this.lblMinSections.Size = new System.Drawing.Size(203, 27);
            this.lblMinSections.TabIndex = 1;
            this.lblMinSections.Text = "Минимум разделов:";
            // 
            // nudMaxSections
            // 
            this.nudMaxSections.Location = new System.Drawing.Point(288, 174);
            this.nudMaxSections.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMaxSections.Name = "nudMaxSections";
            this.nudMaxSections.Size = new System.Drawing.Size(212, 35);
            this.nudMaxSections.TabIndex = 3;
            // 
            // lblMaxSections
            // 
            this.lblMaxSections.AutoSize = true;
            this.lblMaxSections.Location = new System.Drawing.Point(74, 176);
            this.lblMaxSections.Name = "lblMaxSections";
            this.lblMaxSections.Size = new System.Drawing.Size(211, 27);
            this.lblMaxSections.TabIndex = 1;
            this.lblMaxSections.Text = "Максимум разделов:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число товаров, генерируемых в разделе:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxWares
            // 
            this.lblMaxWares.AutoSize = true;
            this.lblMaxWares.Location = new System.Drawing.Point(74, 314);
            this.lblMaxWares.Name = "lblMaxWares";
            this.lblMaxWares.Size = new System.Drawing.Size(198, 27);
            this.lblMaxWares.TabIndex = 1;
            this.lblMaxWares.Text = "Максимум товаров:";
            // 
            // nudMaxWares
            // 
            this.nudMaxWares.Location = new System.Drawing.Point(278, 312);
            this.nudMaxWares.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMaxWares.Name = "nudMaxWares";
            this.nudMaxWares.Size = new System.Drawing.Size(222, 35);
            this.nudMaxWares.TabIndex = 3;
            // 
            // lblMinWares
            // 
            this.lblMinWares.AutoSize = true;
            this.lblMinWares.Location = new System.Drawing.Point(74, 273);
            this.lblMinWares.Name = "lblMinWares";
            this.lblMinWares.Size = new System.Drawing.Size(190, 27);
            this.lblMinWares.TabIndex = 1;
            this.lblMinWares.Text = "Минимум товаров:";
            // 
            // nudMinWares
            // 
            this.nudMinWares.Location = new System.Drawing.Point(270, 271);
            this.nudMinWares.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMinWares.Name = "nudMinWares";
            this.nudMinWares.Size = new System.Drawing.Size(231, 35);
            this.nudMinWares.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(31, 370);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(502, 77);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Сгенерировать";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // RandomSectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 469);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.nudMinWares);
            this.Controls.Add(this.lblMinWares);
            this.Controls.Add(this.nudMaxWares);
            this.Controls.Add(this.lblMaxWares);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaxSections);
            this.Controls.Add(this.nudMaxSections);
            this.Controls.Add(this.lblMinSections);
            this.Controls.Add(this.nudMinSections);
            this.Controls.Add(this.lblGenerate);
            this.Controls.Add(this.lblRandom);
            this.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RandomSectionsForm";
            this.Text = "Генератор разделов";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinWares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lblGenerate;
        private System.Windows.Forms.NumericUpDown nudMinSections;
        private System.Windows.Forms.Label lblMinSections;
        private System.Windows.Forms.NumericUpDown nudMaxSections;
        private System.Windows.Forms.Label lblMaxSections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxWares;
        private System.Windows.Forms.NumericUpDown nudMaxWares;
        private System.Windows.Forms.Label lblMinWares;
        private System.Windows.Forms.NumericUpDown nudMinWares;
        private System.Windows.Forms.Button btnAccept;
    }
}