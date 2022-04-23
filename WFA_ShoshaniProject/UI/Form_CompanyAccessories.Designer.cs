namespace WFA_ShoshaniProject.UI
{
    partial class Form_CompanyAccessories
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.listBox_CompaniesAccessories = new System.Windows.Forms.ListBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(115, 110);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(82, 26);
            this.textBox_Name.TabIndex = 2;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(32, 155);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(77, 63);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // listBox_CompaniesAccessories
            // 
            this.listBox_CompaniesAccessories.FormattingEnabled = true;
            this.listBox_CompaniesAccessories.ItemHeight = 20;
            this.listBox_CompaniesAccessories.Location = new System.Drawing.Point(260, 18);
            this.listBox_CompaniesAccessories.Name = "listBox_CompaniesAccessories";
            this.listBox_CompaniesAccessories.Size = new System.Drawing.Size(238, 324);
            this.listBox_CompaniesAccessories.TabIndex = 4;
            this.listBox_CompaniesAccessories.DoubleClick += new System.EventHandler(this.listBox_CompanyAccessories_DoubleClick);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(111, 65);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 20);
            this.label_ID.TabIndex = 5;
            this.label_ID.Text = "0";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(115, 156);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(112, 62);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(32, 224);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(195, 63);
            this.button_Save.TabIndex = 7;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form_CompanyAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper4;
            this.ClientSize = new System.Drawing.Size(533, 391);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.listBox_CompaniesAccessories);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_CompanyAccessories";
            this.Text = "Company Accessories";
            this.Load += new System.EventHandler(this.Form_CompanyAccessories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ListBox listBox_CompaniesAccessories;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
    }
}