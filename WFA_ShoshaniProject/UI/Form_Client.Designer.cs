namespace WFA_ShoshaniProject
{
    partial class Form1
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
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.comoBox_threedigits = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox_FilterId = new System.Windows.Forms.TextBox();
            this.textBox_FilterLastName = new System.Windows.Forms.TextBox();
            this.textBox_FilterCell = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button_City = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox_FirstName.Location = new System.Drawing.Point(169, 25);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(154, 31);
            this.textBox_FirstName.TabIndex = 0;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox_LastName.Location = new System.Drawing.Point(169, 72);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(154, 31);
            this.textBox_LastName.TabIndex = 1;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox_Email.Location = new System.Drawing.Point(169, 161);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(154, 31);
            this.textBox_Email.TabIndex = 3;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox_Phone.Location = new System.Drawing.Point(236, 212);
            this.textBox_Phone.MaxLength = 7;
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(87, 31);
            this.textBox_Phone.TabIndex = 5;
            this.textBox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Phone_KeyPress);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox_ID.Location = new System.Drawing.Point(169, 264);
            this.textBox_ID.MaxLength = 9;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(154, 31);
            this.textBox_ID.TabIndex = 6;
            this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            // 
            // comoBox_threedigits
            // 
            this.comoBox_threedigits.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.comoBox_threedigits.FormattingEnabled = true;
            this.comoBox_threedigits.Items.AddRange(new object[] {
            "050",
            "052",
            "053",
            "054",
            "058"});
            this.comoBox_threedigits.Location = new System.Drawing.Point(169, 212);
            this.comoBox_threedigits.Name = "comoBox_threedigits";
            this.comoBox_threedigits.Size = new System.Drawing.Size(61, 32);
            this.comoBox_threedigits.TabIndex = 4;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.Control;
            this.save_button.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.save_button.Location = new System.Drawing.Point(38, 306);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(285, 34);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox9.Location = new System.Drawing.Point(25, 264);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(117, 31);
            this.textBox9.TabIndex = 10;
            this.textBox9.Text = "ID";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox10.Location = new System.Drawing.Point(25, 214);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(117, 31);
            this.textBox10.TabIndex = 11;
            this.textBox10.Text = "Phone Number";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox11.Location = new System.Drawing.Point(25, 161);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(117, 31);
            this.textBox11.TabIndex = 12;
            this.textBox11.Text = "Email";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox13.Location = new System.Drawing.Point(25, 72);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(117, 31);
            this.textBox13.TabIndex = 14;
            this.textBox13.Text = "Last Name";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox14.Location = new System.Drawing.Point(25, 25);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(117, 31);
            this.textBox14.TabIndex = 15;
            this.textBox14.Text = "Fisrt Name";
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 24;
            this.listBox_Clients.Location = new System.Drawing.Point(329, 76);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(162, 172);
            this.listBox_Clients.TabIndex = 16;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Client_DoubleClick);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(382, 44);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(0, 20);
            this.label_Id.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox1.Location = new System.Drawing.Point(329, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(32, 31);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "ID";
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Filter.Controls.Add(this.textBox7);
            this.groupBox_Filter.Controls.Add(this.textBox_FilterId);
            this.groupBox_Filter.Controls.Add(this.textBox_FilterLastName);
            this.groupBox_Filter.Controls.Add(this.textBox_FilterCell);
            this.groupBox_Filter.Controls.Add(this.textBox3);
            this.groupBox_Filter.Controls.Add(this.textBox2);
            this.groupBox_Filter.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.groupBox_Filter.Location = new System.Drawing.Point(524, 44);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(222, 166);
            this.groupBox_Filter.TabIndex = 19;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(0, 25);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(39, 31);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "ID";
            // 
            // textBox_FilterId
            // 
            this.textBox_FilterId.Location = new System.Drawing.Point(111, 25);
            this.textBox_FilterId.Name = "textBox_FilterId";
            this.textBox_FilterId.Size = new System.Drawing.Size(100, 31);
            this.textBox_FilterId.TabIndex = 4;
            this.textBox_FilterId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            this.textBox_FilterId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterLastName
            // 
            this.textBox_FilterLastName.Location = new System.Drawing.Point(111, 62);
            this.textBox_FilterLastName.Name = "textBox_FilterLastName";
            this.textBox_FilterLastName.Size = new System.Drawing.Size(100, 31);
            this.textBox_FilterLastName.TabIndex = 3;
            this.textBox_FilterLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            this.textBox_FilterLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_FilterCell
            // 
            this.textBox_FilterCell.Location = new System.Drawing.Point(111, 101);
            this.textBox_FilterCell.Name = "textBox_FilterCell";
            this.textBox_FilterCell.Size = new System.Drawing.Size(100, 31);
            this.textBox_FilterCell.TabIndex = 2;
            this.textBox_FilterCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Phone_KeyPress);
            this.textBox_FilterCell.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 31);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Phone#";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 31);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Last Name";
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.button_Clear.Location = new System.Drawing.Point(38, 358);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(105, 46);
            this.button_Clear.TabIndex = 20;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button_Delete.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.button_Delete.Location = new System.Drawing.Point(203, 358);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(120, 46);
            this.button_Delete.TabIndex = 21;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // comboBox_City
            // 
            this.comboBox_City.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(169, 118);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(121, 32);
            this.comboBox_City.TabIndex = 23;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox12.Location = new System.Drawing.Point(25, 118);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(117, 31);
            this.textBox12.TabIndex = 13;
            this.textBox12.Text = "City";
            // 
            // button_City
            // 
            this.button_City.Location = new System.Drawing.Point(296, 118);
            this.button_City.Name = "button_City";
            this.button_City.Size = new System.Drawing.Size(27, 29);
            this.button_City.TabIndex = 24;
            this.button_City.Text = "+";
            this.button_City.UseVisualStyleBackColor = true;
            this.button_City.Click += new System.EventHandler(this.button_City_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WFA_ShoshaniProject.Properties.Resources.תמונה41;
            this.pictureBox1.Location = new System.Drawing.Point(501, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 463);
            this.Controls.Add(this.button_City);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.listBox_Clients);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.comoBox_threedigits);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Name = "Form1";
            this.Text = "Yonatan Shoshani - Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.ComboBox comoBox_threedigits;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.TextBox textBox_FilterId;
        private System.Windows.Forms.TextBox textBox_FilterLastName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_FilterCell;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button_City;
    }
}

