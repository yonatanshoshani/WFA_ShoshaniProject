namespace WFA_ShoshaniProject.UI
{
    partial class Form_Accessories
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Company = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_CompanyAccessories = new System.Windows.Forms.ComboBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.comboBox_CompanyFilter = new System.Windows.Forms.ComboBox();
            this.comboBox_CategoryFilter = new System.Windows.Forms.ComboBox();
            this.textBox_NameFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_Accessories = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(578, 62);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 20);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label2.Location = new System.Drawing.Point(487, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label_Company.Location = new System.Drawing.Point(487, 203);
            this.label_Company.Name = "label_Company";
            this.label_Company.Size = new System.Drawing.Size(94, 24);
            this.label_Company.TabIndex = 2;
            this.label_Company.Text = "Company";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label_Category.Location = new System.Drawing.Point(487, 151);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(87, 24);
            this.label_Category.TabIndex = 3;
            this.label_Category.Text = "Category";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label_Name.Location = new System.Drawing.Point(487, 113);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(62, 24);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(582, 107);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 26);
            this.textBox_Name.TabIndex = 5;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(582, 151);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Category.TabIndex = 6;
            // 
            // comboBox_CompanyAccessories
            // 
            this.comboBox_CompanyAccessories.FormattingEnabled = true;
            this.comboBox_CompanyAccessories.Location = new System.Drawing.Point(582, 195);
            this.comboBox_CompanyAccessories.Name = "comboBox_CompanyAccessories";
            this.comboBox_CompanyAccessories.Size = new System.Drawing.Size(121, 28);
            this.comboBox_CompanyAccessories.TabIndex = 7;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Filter.Controls.Add(this.comboBox_CompanyFilter);
            this.groupBox_Filter.Controls.Add(this.comboBox_CategoryFilter);
            this.groupBox_Filter.Controls.Add(this.textBox_NameFilter);
            this.groupBox_Filter.Controls.Add(this.label1);
            this.groupBox_Filter.Controls.Add(this.label3);
            this.groupBox_Filter.Controls.Add(this.label4);
            this.groupBox_Filter.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.groupBox_Filter.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(244, 234);
            this.groupBox_Filter.TabIndex = 8;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // comboBox_CompanyFilter
            // 
            this.comboBox_CompanyFilter.FormattingEnabled = true;
            this.comboBox_CompanyFilter.Location = new System.Drawing.Point(117, 144);
            this.comboBox_CompanyFilter.Name = "comboBox_CompanyFilter";
            this.comboBox_CompanyFilter.Size = new System.Drawing.Size(121, 32);
            this.comboBox_CompanyFilter.TabIndex = 15;
            this.comboBox_CompanyFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // comboBox_CategoryFilter
            // 
            this.comboBox_CategoryFilter.FormattingEnabled = true;
            this.comboBox_CategoryFilter.Location = new System.Drawing.Point(117, 98);
            this.comboBox_CategoryFilter.Name = "comboBox_CategoryFilter";
            this.comboBox_CategoryFilter.Size = new System.Drawing.Size(121, 32);
            this.comboBox_CategoryFilter.TabIndex = 14;
            this.comboBox_CategoryFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // textBox_NameFilter
            // 
            this.textBox_NameFilter.Location = new System.Drawing.Point(122, 57);
            this.textBox_NameFilter.Name = "textBox_NameFilter";
            this.textBox_NameFilter.Size = new System.Drawing.Size(100, 31);
            this.textBox_NameFilter.TabIndex = 13;
            this.textBox_NameFilter.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label4.Location = new System.Drawing.Point(18, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Company";
            // 
            // listBox_Accessories
            // 
            this.listBox_Accessories.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.listBox_Accessories.FormattingEnabled = true;
            this.listBox_Accessories.ItemHeight = 24;
            this.listBox_Accessories.Location = new System.Drawing.Point(293, 27);
            this.listBox_Accessories.Name = "listBox_Accessories";
            this.listBox_Accessories.Size = new System.Drawing.Size(160, 316);
            this.listBox_Accessories.TabIndex = 12;
            this.listBox_Accessories.DoubleClick += new System.EventHandler(this.listBox_Accessories_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WFA_ShoshaniProject.Properties.Resources.תמונה6;
            this.pictureBox1.Location = new System.Drawing.Point(491, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(51, 331);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(200, 41);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(53, 286);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(88, 39);
            this.button_Clear.TabIndex = 15;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(151, 286);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(100, 39);
            this.button_Delete.TabIndex = 16;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(709, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 28);
            this.button4.TabIndex = 17;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Company_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(709, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 28);
            this.button5.TabIndex = 18;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Category_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(583, 238);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "In Stock";
            // 
            // Form_Accessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox_Accessories);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.comboBox_CompanyAccessories);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_Company);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ID);
            this.Name = "Form_Accessories";
            this.Text = "Accessories";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_CompanyAccessories;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_Accessories;
        private System.Windows.Forms.ComboBox comboBox_CompanyFilter;
        private System.Windows.Forms.ComboBox comboBox_CategoryFilter;
        private System.Windows.Forms.TextBox textBox_NameFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
    }
}