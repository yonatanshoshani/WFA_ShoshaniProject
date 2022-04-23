namespace WFA_ShoshaniProject.UI
{
    partial class Form_Products
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Company = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.comboBox_CompanyFilter = new System.Windows.Forms.ComboBox();
            this.comboBox_CategoryFilter = new System.Windows.Forms.ComboBox();
            this.textBox_NameFilter = new System.Windows.Forms.TextBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.listBox_Products = new System.Windows.Forms.ListBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.ID_label = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Category1 = new System.Windows.Forms.Label();
            this.label_Company1 = new System.Windows.Forms.Label();
            this.label_Name1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(16, 35);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(51, 20);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.Location = new System.Drawing.Point(6, 80);
            this.label_Company.Name = "label_Company";
            this.label_Company.Size = new System.Drawing.Size(76, 20);
            this.label_Company.TabIndex = 1;
            this.label_Company.Text = "Company";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(6, 132);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(73, 20);
            this.label_Category.TabIndex = 2;
            this.label_Category.Text = "Category";
            // 
            // comboBox_CompanyFilter
            // 
            this.comboBox_CompanyFilter.FormattingEnabled = true;
            this.comboBox_CompanyFilter.Location = new System.Drawing.Point(103, 80);
            this.comboBox_CompanyFilter.Name = "comboBox_CompanyFilter";
            this.comboBox_CompanyFilter.Size = new System.Drawing.Size(121, 28);
            this.comboBox_CompanyFilter.TabIndex = 3;
            this.comboBox_CompanyFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // comboBox_CategoryFilter
            // 
            this.comboBox_CategoryFilter.FormattingEnabled = true;
            this.comboBox_CategoryFilter.Location = new System.Drawing.Point(103, 124);
            this.comboBox_CategoryFilter.Name = "comboBox_CategoryFilter";
            this.comboBox_CategoryFilter.Size = new System.Drawing.Size(121, 28);
            this.comboBox_CategoryFilter.TabIndex = 4;
            this.comboBox_CategoryFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // textBox_NameFilter
            // 
            this.textBox_NameFilter.Location = new System.Drawing.Point(103, 29);
            this.textBox_NameFilter.Name = "textBox_NameFilter";
            this.textBox_NameFilter.Size = new System.Drawing.Size(100, 26);
            this.textBox_NameFilter.TabIndex = 5;
            this.textBox_NameFilter.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Filter.Controls.Add(this.label_Name);
            this.groupBox_Filter.Controls.Add(this.label_Category);
            this.groupBox_Filter.Controls.Add(this.comboBox_CategoryFilter);
            this.groupBox_Filter.Controls.Add(this.label_Company);
            this.groupBox_Filter.Controls.Add(this.textBox_NameFilter);
            this.groupBox_Filter.Controls.Add(this.comboBox_CompanyFilter);
            this.groupBox_Filter.Location = new System.Drawing.Point(12, 21);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(280, 182);
            this.groupBox_Filter.TabIndex = 6;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // listBox_Products
            // 
            this.listBox_Products.FormattingEnabled = true;
            this.listBox_Products.ItemHeight = 20;
            this.listBox_Products.Location = new System.Drawing.Point(12, 220);
            this.listBox_Products.Name = "listBox_Products";
            this.listBox_Products.Size = new System.Drawing.Size(280, 164);
            this.listBox_Products.TabIndex = 6;
            this.listBox_Products.DoubleClick += new System.EventHandler(this.listBox_Product_DoubleClick);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(590, 252);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(87, 34);
            this.button_Save.TabIndex = 7;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(470, 252);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(81, 34);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(466, 56);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(26, 20);
            this.ID_label.TabIndex = 9;
            this.ID_label.Text = "ID";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(552, 53);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(18, 20);
            this.label_Id.TabIndex = 10;
            this.label_Id.Text = "0";
            // 
            // label_Category1
            // 
            this.label_Category1.AutoSize = true;
            this.label_Category1.Location = new System.Drawing.Point(466, 183);
            this.label_Category1.Name = "label_Category1";
            this.label_Category1.Size = new System.Drawing.Size(73, 20);
            this.label_Category1.TabIndex = 11;
            this.label_Category1.Text = "Category";
            // 
            // label_Company1
            // 
            this.label_Company1.AutoSize = true;
            this.label_Company1.Location = new System.Drawing.Point(466, 145);
            this.label_Company1.Name = "label_Company1";
            this.label_Company1.Size = new System.Drawing.Size(76, 20);
            this.label_Company1.TabIndex = 12;
            this.label_Company1.Text = "Company";
            // 
            // label_Name1
            // 
            this.label_Name1.AutoSize = true;
            this.label_Name1.Location = new System.Drawing.Point(466, 101);
            this.label_Name1.Name = "label_Name1";
            this.label_Name1.Size = new System.Drawing.Size(51, 20);
            this.label_Name1.TabIndex = 13;
            this.label_Name1.Text = "Name";
            this.label_Name1.Click += new System.EventHandler(this.label_Name1_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(556, 101);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 26);
            this.textBox_Name.TabIndex = 14;
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(556, 142);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Company.TabIndex = 6;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(556, 183);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Category.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Company_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Category_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(556, 220);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown2.TabIndex = 18;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(517, 305);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(98, 36);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper4;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_Company);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name1);
            this.Controls.Add(this.label_Company1);
            this.Controls.Add(this.label_Category1);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.listBox_Products);
            this.Controls.Add(this.groupBox_Filter);
            this.Name = "Form_Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form_Products_Load);
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.ComboBox comboBox_CompanyFilter;
        private System.Windows.Forms.ComboBox comboBox_CategoryFilter;
        private System.Windows.Forms.TextBox textBox_NameFilter;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.ListBox listBox_Products;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Category1;
        private System.Windows.Forms.Label label_Company1;
        private System.Windows.Forms.Label label_Name1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Company;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button_Delete;
    }
}