namespace WFA_ShoshaniProject.UI
{
    partial class Form_Home
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
            this.button_Client = new System.Windows.Forms.Button();
            this.button_Accessory = new System.Windows.Forms.Button();
            this.button_Product = new System.Windows.Forms.Button();
            this.button_Order = new System.Windows.Forms.Button();
            this.button_Reports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Client
            // 
            this.button_Client.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Client.Location = new System.Drawing.Point(71, 24);
            this.button_Client.Name = "button_Client";
            this.button_Client.Size = new System.Drawing.Size(154, 52);
            this.button_Client.TabIndex = 0;
            this.button_Client.Text = "Client";
            this.button_Client.UseVisualStyleBackColor = false;
            this.button_Client.Click += new System.EventHandler(this.button_Client_Click);
            // 
            // button_Accessory
            // 
            this.button_Accessory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Accessory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Accessory.Location = new System.Drawing.Point(882, 24);
            this.button_Accessory.Name = "button_Accessory";
            this.button_Accessory.Size = new System.Drawing.Size(154, 52);
            this.button_Accessory.TabIndex = 2;
            this.button_Accessory.Text = "Accessory";
            this.button_Accessory.UseVisualStyleBackColor = false;
            this.button_Accessory.Click += new System.EventHandler(this.button_Accessory_Click);
            // 
            // button_Product
            // 
            this.button_Product.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Product.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Product.Location = new System.Drawing.Point(678, 24);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(154, 52);
            this.button_Product.TabIndex = 3;
            this.button_Product.Text = "Product";
            this.button_Product.UseVisualStyleBackColor = false;
            this.button_Product.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // button_Order
            // 
            this.button_Order.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Order.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Order.Location = new System.Drawing.Point(471, 24);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(154, 52);
            this.button_Order.TabIndex = 4;
            this.button_Order.Text = "Order";
            this.button_Order.UseVisualStyleBackColor = false;
            this.button_Order.Click += new System.EventHandler(this.button_Order_Click);
            // 
            // button_Reports
            // 
            this.button_Reports.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Reports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Reports.Location = new System.Drawing.Point(257, 24);
            this.button_Reports.Name = "button_Reports";
            this.button_Reports.Size = new System.Drawing.Size(154, 52);
            this.button_Reports.TabIndex = 5;
            this.button_Reports.Text = "Reports";
            this.button_Reports.UseVisualStyleBackColor = false;
            this.button_Reports.Click += new System.EventHandler(this.button_Reports_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.תמונה5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 614);
            this.Controls.Add(this.button_Reports);
            this.Controls.Add(this.button_Order);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.button_Accessory);
            this.Controls.Add(this.button_Client);
            this.DoubleBuffered = true;
            this.Name = "Form_Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Client;
        private System.Windows.Forms.Button button_Accessory;
        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.Button button_Order;
        private System.Windows.Forms.Button button_Reports;
    }
}