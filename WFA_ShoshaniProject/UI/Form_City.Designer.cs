namespace WFA_ShoshaniProject.UI
{
    partial class Form_City
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
            this.listBox_City = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.pictureBox_City = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_City)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_City
            // 
            this.listBox_City.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.listBox_City.FormattingEnabled = true;
            this.listBox_City.ItemHeight = 24;
            this.listBox_City.Location = new System.Drawing.Point(311, 48);
            this.listBox_City.Name = "listBox_City";
            this.listBox_City.Size = new System.Drawing.Size(123, 148);
            this.listBox_City.TabIndex = 0;
            this.listBox_City.DoubleClick += new System.EventHandler(this.listBox_City_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label1.Location = new System.Drawing.Point(92, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label2.Location = new System.Drawing.Point(92, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 3;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(160, 65);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(0, 20);
            this.label_Id.TabIndex = 4;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.button_Save.Location = new System.Drawing.Point(96, 159);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(74, 44);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.button_Clear.Location = new System.Drawing.Point(210, 151);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(78, 27);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Tomato;
            this.button_Delete.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.button_Delete.Location = new System.Drawing.Point(210, 184);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(78, 28);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox_Name.Location = new System.Drawing.Point(164, 105);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 31);
            this.textBox_Name.TabIndex = 8;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // pictureBox_City
            // 
            this.pictureBox_City.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_City.ErrorImage = null;
            this.pictureBox_City.Image = global::WFA_ShoshaniProject.Properties.Resources.תמונה2;
            this.pictureBox_City.Location = new System.Drawing.Point(96, 218);
            this.pictureBox_City.Name = "pictureBox_City";
            this.pictureBox_City.Size = new System.Drawing.Size(300, 97);
            this.pictureBox_City.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_City.TabIndex = 9;
            this.pictureBox_City.TabStop = false;
            // 
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(537, 336);
            this.Controls.Add(this.pictureBox_City);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_City);
            this.Name = "Form_City";
            this.Text = "City";
            this.Load += new System.EventHandler(this.Form_City_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_City)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.PictureBox pictureBox_City;
    }
}