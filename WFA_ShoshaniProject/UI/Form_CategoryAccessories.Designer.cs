namespace WFA_ShoshaniProject.UI
{
    partial class Form_CategoryAccessories
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_CategoryAccessories = new System.Windows.Forms.ListBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label_ID.Location = new System.Drawing.Point(94, 20);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(20, 24);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // listBox_CategoryAccessories
            // 
            this.listBox_CategoryAccessories.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.listBox_CategoryAccessories.FormattingEnabled = true;
            this.listBox_CategoryAccessories.ItemHeight = 24;
            this.listBox_CategoryAccessories.Location = new System.Drawing.Point(322, 20);
            this.listBox_CategoryAccessories.Name = "listBox_CategoryAccessories";
            this.listBox_CategoryAccessories.Size = new System.Drawing.Size(250, 268);
            this.listBox_CategoryAccessories.TabIndex = 3;
            this.listBox_CategoryAccessories.DoubleClick += new System.EventHandler(this.listBox_CategoryAccessories_DoubleClick);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.button_Clear.Location = new System.Drawing.Point(151, 158);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(90, 39);
            this.button_Clear.TabIndex = 4;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.button_Delete.Location = new System.Drawing.Point(52, 158);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(93, 39);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.button_Save.Location = new System.Drawing.Point(52, 203);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(189, 34);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.textBox_Name.Location = new System.Drawing.Point(86, 77);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 31);
            this.textBox_Name.TabIndex = 7;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WFA_ShoshaniProject.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(52, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form_CategoryAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper2;
            this.ClientSize = new System.Drawing.Size(584, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.listBox_CategoryAccessories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label1);
            this.Name = "Form_CategoryAccessories";
            this.Text = "Category Accessories";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_CategoryAccessories;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}