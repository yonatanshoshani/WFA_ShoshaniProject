namespace WFA_ShoshaniProject.UI
{
    partial class Form_Order
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
            this.Order_Accessories = new System.Windows.Forms.TabControl();
            this.orderDetails = new System.Windows.Forms.TabPage();
            this.listBox_Orders = new System.Windows.Forms.ListBox();
            this.button_SaveOrder = new System.Windows.Forms.Button();
            this.button_ClearOrder = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_Client = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.label_ChooseClient = new System.Windows.Forms.Label();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.ClientFilterTextBox = new System.Windows.Forms.TextBox();
            this.IDFilterTextBox = new System.Windows.Forms.TextBox();
            this.label_ClientFilter = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDatePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Comment = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.labe_ID = new System.Windows.Forms.Label();
            this.orderClient = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PhoneFilterTextBox = new System.Windows.Forms.TextBox();
            this.LastNameFilterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderItems = new System.Windows.Forms.TabPage();
            this.CategoryFilterComboBox = new System.Windows.Forms.ComboBox();
            this.button_Minus = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Plus = new System.Windows.Forms.Button();
            this.listBox_InOrderProductsCount = new System.Windows.Forms.ListBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.listBox_PotentialProducts = new System.Windows.Forms.ListBox();
            this.listBox_InOrderProducts = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_NameProoduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CompanyFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Plus1 = new System.Windows.Forms.Button();
            this.button_Minus1 = new System.Windows.Forms.Button();
            this.button_Save1 = new System.Windows.Forms.Button();
            this.button_Clear1 = new System.Windows.Forms.Button();
            this.groupBox_Filter1 = new System.Windows.Forms.GroupBox();
            this.textBox_AccessoriesName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_CategryFilter = new System.Windows.Forms.ComboBox();
            this.comboBox_CompanyFilter = new System.Windows.Forms.ComboBox();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_Accessory = new System.Windows.Forms.Label();
            this.listBox_InOrderAccessoriesCount = new System.Windows.Forms.ListBox();
            this.listBox_PotentialAccessories = new System.Windows.Forms.ListBox();
            this.listBox_InOrderAccessories = new System.Windows.Forms.ListBox();
            this.Order_Accessories.SuspendLayout();
            this.orderDetails.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.orderClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.orderItems.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_Filter1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Order_Accessories
            // 
            this.Order_Accessories.Controls.Add(this.orderDetails);
            this.Order_Accessories.Controls.Add(this.orderClient);
            this.Order_Accessories.Controls.Add(this.orderItems);
            this.Order_Accessories.Controls.Add(this.tabPage1);
            this.Order_Accessories.Location = new System.Drawing.Point(0, 0);
            this.Order_Accessories.Name = "Order_Accessories";
            this.Order_Accessories.SelectedIndex = 0;
            this.Order_Accessories.Size = new System.Drawing.Size(754, 438);
            this.Order_Accessories.TabIndex = 0;
            // 
            // orderDetails
            // 
            this.orderDetails.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper;
            this.orderDetails.Controls.Add(this.listBox_Orders);
            this.orderDetails.Controls.Add(this.button_SaveOrder);
            this.orderDetails.Controls.Add(this.button_ClearOrder);
            this.orderDetails.Controls.Add(this.button_Delete);
            this.orderDetails.Controls.Add(this.label_Client);
            this.orderDetails.Controls.Add(this.textBox_Comment);
            this.orderDetails.Controls.Add(this.label_ChooseClient);
            this.orderDetails.Controls.Add(this.groupBox_Filter);
            this.orderDetails.Controls.Add(this.label_Comment);
            this.orderDetails.Controls.Add(this.dateTimePicker);
            this.orderDetails.Controls.Add(this.label_Date);
            this.orderDetails.Controls.Add(this.label_Id);
            this.orderDetails.Controls.Add(this.labe_ID);
            this.orderDetails.Location = new System.Drawing.Point(4, 29);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.orderDetails.Size = new System.Drawing.Size(746, 405);
            this.orderDetails.TabIndex = 0;
            this.orderDetails.Text = "Order Details";
            this.orderDetails.UseVisualStyleBackColor = true;
            // 
            // listBox_Orders
            // 
            this.listBox_Orders.FormattingEnabled = true;
            this.listBox_Orders.ItemHeight = 20;
            this.listBox_Orders.Location = new System.Drawing.Point(289, 36);
            this.listBox_Orders.Name = "listBox_Orders";
            this.listBox_Orders.Size = new System.Drawing.Size(197, 304);
            this.listBox_Orders.TabIndex = 11;
            this.listBox_Orders.DoubleClick += new System.EventHandler(this.listBox_Order_DoubleClick);
            // 
            // button_SaveOrder
            // 
            this.button_SaveOrder.Location = new System.Drawing.Point(15, 269);
            this.button_SaveOrder.Name = "button_SaveOrder";
            this.button_SaveOrder.Size = new System.Drawing.Size(221, 45);
            this.button_SaveOrder.TabIndex = 17;
            this.button_SaveOrder.Text = "Save";
            this.button_SaveOrder.UseVisualStyleBackColor = true;
            this.button_SaveOrder.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button_ClearOrder
            // 
            this.button_ClearOrder.Location = new System.Drawing.Point(142, 225);
            this.button_ClearOrder.Name = "button_ClearOrder";
            this.button_ClearOrder.Size = new System.Drawing.Size(94, 38);
            this.button_ClearOrder.TabIndex = 16;
            this.button_ClearOrder.Text = "Clear";
            this.button_ClearOrder.UseVisualStyleBackColor = true;
            this.button_ClearOrder.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(15, 225);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(95, 38);
            this.button_Delete.TabIndex = 15;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Location = new System.Drawing.Point(506, 314);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(49, 20);
            this.label_Client.TabIndex = 14;
            this.label_Client.Text = "Client";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(510, 163);
            this.textBox_Comment.Multiline = true;
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(230, 90);
            this.textBox_Comment.TabIndex = 13;
            // 
            // label_ChooseClient
            // 
            this.label_ChooseClient.AutoSize = true;
            this.label_ChooseClient.Location = new System.Drawing.Point(588, 314);
            this.label_ChooseClient.Name = "label_ChooseClient";
            this.label_ChooseClient.Size = new System.Drawing.Size(106, 20);
            this.label_ChooseClient.TabIndex = 12;
            this.label_ChooseClient.Text = "None Chosen";
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.ClientFilterTextBox);
            this.groupBox_Filter.Controls.Add(this.IDFilterTextBox);
            this.groupBox_Filter.Controls.Add(this.label_ClientFilter);
            this.groupBox_Filter.Controls.Add(this.label_To);
            this.groupBox_Filter.Controls.Add(this.label_From);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_StartDate);
            this.groupBox_Filter.Controls.Add(this.EndDatePickerFilter);
            this.groupBox_Filter.Controls.Add(this.label1);
            this.groupBox_Filter.Location = new System.Drawing.Point(8, 6);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(298, 234);
            this.groupBox_Filter.TabIndex = 5;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // ClientFilterTextBox
            // 
            this.ClientFilterTextBox.Location = new System.Drawing.Point(75, 140);
            this.ClientFilterTextBox.Name = "ClientFilterTextBox";
            this.ClientFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.ClientFilterTextBox.TabIndex = 12;
            this.ClientFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Order_Filter);
            // 
            // IDFilterTextBox
            // 
            this.IDFilterTextBox.Location = new System.Drawing.Point(75, 19);
            this.IDFilterTextBox.Name = "IDFilterTextBox";
            this.IDFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.IDFilterTextBox.TabIndex = 11;
            this.IDFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Order_Filter);
            // 
            // label_ClientFilter
            // 
            this.label_ClientFilter.AutoSize = true;
            this.label_ClientFilter.Location = new System.Drawing.Point(6, 143);
            this.label_ClientFilter.Name = "label_ClientFilter";
            this.label_ClientFilter.Size = new System.Drawing.Size(49, 20);
            this.label_ClientFilter.TabIndex = 10;
            this.label_ClientFilter.Text = "Client";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Location = new System.Drawing.Point(6, 100);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(27, 20);
            this.label_To.TabIndex = 9;
            this.label_To.Text = "To";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Location = new System.Drawing.Point(6, 56);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(46, 20);
            this.label_From.TabIndex = 8;
            this.label_From.Text = "From";
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Checked = false;
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(75, 51);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_StartDate.TabIndex = 6;
            this.dateTimePicker_StartDate.ValueChanged += new System.EventHandler(this.DatePickerFilter_ValueChanged);
            // 
            // EndDatePickerFilter
            // 
            this.EndDatePickerFilter.Location = new System.Drawing.Point(75, 100);
            this.EndDatePickerFilter.Name = "EndDatePickerFilter";
            this.EndDatePickerFilter.Size = new System.Drawing.Size(200, 26);
            this.EndDatePickerFilter.TabIndex = 7;
            this.EndDatePickerFilter.ValueChanged += new System.EventHandler(this.DatePickerFilter_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label_Comment
            // 
            this.label_Comment.AutoSize = true;
            this.label_Comment.Location = new System.Drawing.Point(506, 140);
            this.label_Comment.Name = "label_Comment";
            this.label_Comment.Size = new System.Drawing.Size(78, 20);
            this.label_Comment.TabIndex = 4;
            this.label_Comment.Text = "Comment";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(556, 76);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 26);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2022, 2, 14, 10, 29, 20, 0);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(506, 76);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(44, 20);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "Date";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(588, 42);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(18, 20);
            this.label_Id.TabIndex = 1;
            this.label_Id.Text = "0";
            // 
            // labe_ID
            // 
            this.labe_ID.AutoSize = true;
            this.labe_ID.Location = new System.Drawing.Point(506, 42);
            this.labe_ID.Name = "labe_ID";
            this.labe_ID.Size = new System.Drawing.Size(26, 20);
            this.labe_ID.TabIndex = 0;
            this.labe_ID.Text = "ID";
            // 
            // orderClient
            // 
            this.orderClient.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper;
            this.orderClient.Controls.Add(this.groupBox2);
            this.orderClient.Controls.Add(this.ClientListBox);
            this.orderClient.Controls.Add(this.groupBox1);
            this.orderClient.Location = new System.Drawing.Point(4, 29);
            this.orderClient.Name = "orderClient";
            this.orderClient.Padding = new System.Windows.Forms.Padding(3);
            this.orderClient.Size = new System.Drawing.Size(746, 405);
            this.orderClient.TabIndex = 1;
            this.orderClient.Text = "Order Client";
            this.orderClient.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PhoneLabel);
            this.groupBox2.Controls.Add(this.FirstNameLabel);
            this.groupBox2.Controls.Add(this.LastNameLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(273, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 148);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Details";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(106, 94);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(103, 20);
            this.PhoneLabel.TabIndex = 10;
            this.PhoneLabel.Text = "None chosen";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(223, 40);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(103, 20);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "None chosen";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(69, 40);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(103, 20);
            this.LastNameLabel.TabIndex = 8;
            this.LastNameLabel.Text = "None chosen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "First";
            // 
            // ClientListBox
            // 
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.ItemHeight = 20;
            this.ClientListBox.Location = new System.Drawing.Point(21, 171);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(218, 184);
            this.ClientListBox.TabIndex = 3;
            this.ClientListBox.SelectedIndexChanged += new System.EventHandler(this.ClientListBox_SelectedIndexChanged);
            this.ClientListBox.DoubleClick += new System.EventHandler(this.ClientListBox_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PhoneFilterTextBox);
            this.groupBox1.Controls.Add(this.LastNameFilterTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // PhoneFilterTextBox
            // 
            this.PhoneFilterTextBox.Location = new System.Drawing.Point(112, 89);
            this.PhoneFilterTextBox.Name = "PhoneFilterTextBox";
            this.PhoneFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.PhoneFilterTextBox.TabIndex = 3;
            this.PhoneFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Client_Filter);
            // 
            // LastNameFilterTextBox
            // 
            this.LastNameFilterTextBox.Location = new System.Drawing.Point(112, 37);
            this.LastNameFilterTextBox.Name = "LastNameFilterTextBox";
            this.LastNameFilterTextBox.Size = new System.Drawing.Size(100, 26);
            this.LastNameFilterTextBox.TabIndex = 2;
            this.LastNameFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Client_Filter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone #";
            // 
            // orderItems
            // 
            this.orderItems.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper;
            this.orderItems.Controls.Add(this.CategoryFilterComboBox);
            this.orderItems.Controls.Add(this.button_Minus);
            this.orderItems.Controls.Add(this.label8);
            this.orderItems.Controls.Add(this.button_Plus);
            this.orderItems.Controls.Add(this.listBox_InOrderProductsCount);
            this.orderItems.Controls.Add(this.button_Clear);
            this.orderItems.Controls.Add(this.button_Save);
            this.orderItems.Controls.Add(this.listBox_PotentialProducts);
            this.orderItems.Controls.Add(this.listBox_InOrderProducts);
            this.orderItems.Controls.Add(this.groupBox3);
            this.orderItems.Location = new System.Drawing.Point(4, 29);
            this.orderItems.Name = "orderItems";
            this.orderItems.Size = new System.Drawing.Size(746, 405);
            this.orderItems.TabIndex = 2;
            this.orderItems.Text = "Order Items";
            this.orderItems.UseVisualStyleBackColor = true;
            // 
            // CategoryFilterComboBox
            // 
            this.CategoryFilterComboBox.FormattingEnabled = true;
            this.CategoryFilterComboBox.Location = new System.Drawing.Point(88, 104);
            this.CategoryFilterComboBox.Name = "CategoryFilterComboBox";
            this.CategoryFilterComboBox.Size = new System.Drawing.Size(121, 28);
            this.CategoryFilterComboBox.TabIndex = 7;
            this.CategoryFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductFilterComboBox_SelectedIndexChanged);
            // 
            // button_Minus
            // 
            this.button_Minus.Location = new System.Drawing.Point(661, 150);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(33, 25);
            this.button_Minus.TabIndex = 5;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Category";
            // 
            // button_Plus
            // 
            this.button_Plus.Location = new System.Drawing.Point(661, 91);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(33, 25);
            this.button_Plus.TabIndex = 4;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
            // 
            // listBox_InOrderProductsCount
            // 
            this.listBox_InOrderProductsCount.FormattingEnabled = true;
            this.listBox_InOrderProductsCount.ItemHeight = 20;
            this.listBox_InOrderProductsCount.Location = new System.Drawing.Point(567, 73);
            this.listBox_InOrderProductsCount.Name = "listBox_InOrderProductsCount";
            this.listBox_InOrderProductsCount.Size = new System.Drawing.Size(60, 284);
            this.listBox_InOrderProductsCount.TabIndex = 6;
            this.listBox_InOrderProductsCount.Click += new System.EventHandler(this.listBox_InOrderProductsCount_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(8, 189);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(82, 41);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(115, 189);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(74, 41);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // listBox_PotentialProducts
            // 
            this.listBox_PotentialProducts.FormattingEnabled = true;
            this.listBox_PotentialProducts.ItemHeight = 20;
            this.listBox_PotentialProducts.Location = new System.Drawing.Point(214, 71);
            this.listBox_PotentialProducts.Name = "listBox_PotentialProducts";
            this.listBox_PotentialProducts.Size = new System.Drawing.Size(171, 284);
            this.listBox_PotentialProducts.TabIndex = 0;
            this.listBox_PotentialProducts.DoubleClick += new System.EventHandler(this.listBox_PotentialProducts_DoubleClick);
            // 
            // listBox_InOrderProducts
            // 
            this.listBox_InOrderProducts.FormattingEnabled = true;
            this.listBox_InOrderProducts.ItemHeight = 20;
            this.listBox_InOrderProducts.Location = new System.Drawing.Point(391, 73);
            this.listBox_InOrderProducts.Name = "listBox_InOrderProducts";
            this.listBox_InOrderProducts.Size = new System.Drawing.Size(161, 284);
            this.listBox_InOrderProducts.TabIndex = 1;
            this.listBox_InOrderProducts.DoubleClick += new System.EventHandler(this.listBox_InOrderProducts_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_NameProoduct);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.CompanyFilterComboBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(3, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 104);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // textBox_NameProoduct
            // 
            this.textBox_NameProoduct.Location = new System.Drawing.Point(106, 23);
            this.textBox_NameProoduct.Name = "textBox_NameProoduct";
            this.textBox_NameProoduct.Size = new System.Drawing.Size(100, 26);
            this.textBox_NameProoduct.TabIndex = 8;
            this.textBox_NameProoduct.TextChanged += new System.EventHandler(this.ProductFilterComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Name";
            // 
            // CompanyFilterComboBox
            // 
            this.CompanyFilterComboBox.FormattingEnabled = true;
            this.CompanyFilterComboBox.Location = new System.Drawing.Point(85, 55);
            this.CompanyFilterComboBox.Name = "CompanyFilterComboBox";
            this.CompanyFilterComboBox.Size = new System.Drawing.Size(121, 28);
            this.CompanyFilterComboBox.TabIndex = 6;
            this.CompanyFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductFilterComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Company";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::WFA_ShoshaniProject.Properties.Resources.wallpaper4;
            this.tabPage1.Controls.Add(this.button_Plus1);
            this.tabPage1.Controls.Add(this.button_Minus1);
            this.tabPage1.Controls.Add(this.button_Save1);
            this.tabPage1.Controls.Add(this.button_Clear1);
            this.tabPage1.Controls.Add(this.groupBox_Filter1);
            this.tabPage1.Controls.Add(this.listBox_InOrderAccessoriesCount);
            this.tabPage1.Controls.Add(this.listBox_PotentialAccessories);
            this.tabPage1.Controls.Add(this.listBox_InOrderAccessories);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 405);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Order Accessories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Plus1
            // 
            this.button_Plus1.Location = new System.Drawing.Point(713, 96);
            this.button_Plus1.Name = "button_Plus1";
            this.button_Plus1.Size = new System.Drawing.Size(27, 29);
            this.button_Plus1.TabIndex = 7;
            this.button_Plus1.Text = "+";
            this.button_Plus1.UseVisualStyleBackColor = true;
            this.button_Plus1.Click += new System.EventHandler(this.button_Plus1_Click);
            // 
            // button_Minus1
            // 
            this.button_Minus1.Location = new System.Drawing.Point(713, 136);
            this.button_Minus1.Name = "button_Minus1";
            this.button_Minus1.Size = new System.Drawing.Size(25, 28);
            this.button_Minus1.TabIndex = 6;
            this.button_Minus1.Text = "-";
            this.button_Minus1.UseVisualStyleBackColor = true;
            this.button_Minus1.Click += new System.EventHandler(this.button_Minus1_Click);
            // 
            // button_Save1
            // 
            this.button_Save1.Location = new System.Drawing.Point(142, 226);
            this.button_Save1.Name = "button_Save1";
            this.button_Save1.Size = new System.Drawing.Size(87, 41);
            this.button_Save1.TabIndex = 5;
            this.button_Save1.Text = "Save";
            this.button_Save1.UseVisualStyleBackColor = true;
            this.button_Save1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button_Clear1
            // 
            this.button_Clear1.Location = new System.Drawing.Point(40, 226);
            this.button_Clear1.Name = "button_Clear1";
            this.button_Clear1.Size = new System.Drawing.Size(78, 41);
            this.button_Clear1.TabIndex = 4;
            this.button_Clear1.Text = "Clear";
            this.button_Clear1.UseVisualStyleBackColor = true;
            // 
            // groupBox_Filter1
            // 
            this.groupBox_Filter1.Controls.Add(this.textBox_AccessoriesName);
            this.groupBox_Filter1.Controls.Add(this.label10);
            this.groupBox_Filter1.Controls.Add(this.comboBox_CategryFilter);
            this.groupBox_Filter1.Controls.Add(this.comboBox_CompanyFilter);
            this.groupBox_Filter1.Controls.Add(this.label_Category);
            this.groupBox_Filter1.Controls.Add(this.label_Accessory);
            this.groupBox_Filter1.Location = new System.Drawing.Point(14, 23);
            this.groupBox_Filter1.Name = "groupBox_Filter1";
            this.groupBox_Filter1.Size = new System.Drawing.Size(245, 141);
            this.groupBox_Filter1.TabIndex = 3;
            this.groupBox_Filter1.TabStop = false;
            this.groupBox_Filter1.Text = "Filter";
            // 
            // textBox_AccessoriesName
            // 
            this.textBox_AccessoriesName.Location = new System.Drawing.Point(108, 34);
            this.textBox_AccessoriesName.Name = "textBox_AccessoriesName";
            this.textBox_AccessoriesName.Size = new System.Drawing.Size(100, 26);
            this.textBox_AccessoriesName.TabIndex = 11;
            this.textBox_AccessoriesName.TextChanged += new System.EventHandler(this.AccessoriesFilterComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Name";
            // 
            // comboBox_CategryFilter
            // 
            this.comboBox_CategryFilter.FormattingEnabled = true;
            this.comboBox_CategryFilter.Location = new System.Drawing.Point(108, 107);
            this.comboBox_CategryFilter.Name = "comboBox_CategryFilter";
            this.comboBox_CategryFilter.Size = new System.Drawing.Size(121, 28);
            this.comboBox_CategryFilter.TabIndex = 9;
            this.comboBox_CategryFilter.SelectedIndexChanged += new System.EventHandler(this.AccessoriesFilterComboBox_SelectedIndexChanged);
            // 
            // comboBox_CompanyFilter
            // 
            this.comboBox_CompanyFilter.FormattingEnabled = true;
            this.comboBox_CompanyFilter.Location = new System.Drawing.Point(108, 69);
            this.comboBox_CompanyFilter.Name = "comboBox_CompanyFilter";
            this.comboBox_CompanyFilter.Size = new System.Drawing.Size(121, 28);
            this.comboBox_CompanyFilter.TabIndex = 8;
            this.comboBox_CompanyFilter.SelectedIndexChanged += new System.EventHandler(this.AccessoriesFilterComboBox_SelectedIndexChanged);
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(-4, 110);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(73, 20);
            this.label_Category.TabIndex = 6;
            this.label_Category.Text = "Category";
            // 
            // label_Accessory
            // 
            this.label_Accessory.AutoSize = true;
            this.label_Accessory.Location = new System.Drawing.Point(-8, 69);
            this.label_Accessory.Name = "label_Accessory";
            this.label_Accessory.Size = new System.Drawing.Size(76, 20);
            this.label_Accessory.TabIndex = 7;
            this.label_Accessory.Text = "Company";
            // 
            // listBox_InOrderAccessoriesCount
            // 
            this.listBox_InOrderAccessoriesCount.FormattingEnabled = true;
            this.listBox_InOrderAccessoriesCount.ItemHeight = 20;
            this.listBox_InOrderAccessoriesCount.Location = new System.Drawing.Point(630, 43);
            this.listBox_InOrderAccessoriesCount.Name = "listBox_InOrderAccessoriesCount";
            this.listBox_InOrderAccessoriesCount.Size = new System.Drawing.Size(77, 244);
            this.listBox_InOrderAccessoriesCount.TabIndex = 2;
            this.listBox_InOrderAccessoriesCount.Click += new System.EventHandler(this.listBox_InOrderAccessoriesCount_Click);
            // 
            // listBox_PotentialAccessories
            // 
            this.listBox_PotentialAccessories.FormattingEnabled = true;
            this.listBox_PotentialAccessories.ItemHeight = 20;
            this.listBox_PotentialAccessories.Location = new System.Drawing.Point(303, 43);
            this.listBox_PotentialAccessories.Name = "listBox_PotentialAccessories";
            this.listBox_PotentialAccessories.Size = new System.Drawing.Size(134, 244);
            this.listBox_PotentialAccessories.TabIndex = 1;
            this.listBox_PotentialAccessories.DoubleClick += new System.EventHandler(this.listBox_PotentialAccessories_DoubleClick);
            // 
            // listBox_InOrderAccessories
            // 
            this.listBox_InOrderAccessories.FormattingEnabled = true;
            this.listBox_InOrderAccessories.ItemHeight = 20;
            this.listBox_InOrderAccessories.Location = new System.Drawing.Point(459, 43);
            this.listBox_InOrderAccessories.Name = "listBox_InOrderAccessories";
            this.listBox_InOrderAccessories.Size = new System.Drawing.Size(141, 244);
            this.listBox_InOrderAccessories.TabIndex = 0;
            this.listBox_InOrderAccessories.Click += new System.EventHandler(this.listBox_InOrderAccessories_Click);
            this.listBox_InOrderAccessories.DoubleClick += new System.EventHandler(this.listBox_InOrderAccessories_DoubleClick);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 462);
            this.Controls.Add(this.Order_Accessories);
            this.Name = "Form_Order";
            this.Text = "Order";
            this.Order_Accessories.ResumeLayout(false);
            this.orderDetails.ResumeLayout(false);
            this.orderDetails.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.orderClient.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.orderItems.ResumeLayout(false);
            this.orderItems.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox_Filter1.ResumeLayout(false);
            this.groupBox_Filter1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Order_Accessories;
        private System.Windows.Forms.TabPage orderDetails;
        private System.Windows.Forms.TabPage orderClient;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label labe_ID;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label_Comment;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        private System.Windows.Forms.DateTimePicker EndDatePickerFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_ClientFilter;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_ChooseClient;
        private System.Windows.Forms.ListBox listBox_Orders;
        private System.Windows.Forms.TabPage orderItems;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PhoneFilterTextBox;
        private System.Windows.Forms.TextBox LastNameFilterTextBox;
        private System.Windows.Forms.TextBox ClientFilterTextBox;
        private System.Windows.Forms.TextBox IDFilterTextBox;
        private System.Windows.Forms.ListBox listBox_PotentialProducts;
        private System.Windows.Forms.ListBox listBox_InOrderProducts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CategoryFilterComboBox;
        private System.Windows.Forms.ComboBox CompanyFilterComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.ListBox listBox_InOrderProductsCount;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Save1;
        private System.Windows.Forms.Button button_Clear1;
        private System.Windows.Forms.GroupBox groupBox_Filter1;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_Accessory;
        private System.Windows.Forms.ListBox listBox_InOrderAccessoriesCount;
        private System.Windows.Forms.ListBox listBox_PotentialAccessories;
        private System.Windows.Forms.ListBox listBox_InOrderAccessories;
        private System.Windows.Forms.ComboBox comboBox_CategryFilter;
        private System.Windows.Forms.ComboBox comboBox_CompanyFilter;
        private System.Windows.Forms.Button button_Plus1;
        private System.Windows.Forms.Button button_Minus1;
        private System.Windows.Forms.Button button_SaveOrder;
        private System.Windows.Forms.Button button_ClearOrder;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_NameProoduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_AccessoriesName;
        private System.Windows.Forms.Label label10;
    }
}