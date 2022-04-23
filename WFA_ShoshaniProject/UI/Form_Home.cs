using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_ShoshaniProject.BL;
using WFA_ShoshaniProject.DAL;
using WFA_ShoshaniProject.UI;

namespace WFA_ShoshaniProject.UI
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }
        private void button_Client_Click(object sender, EventArgs e)
        {
            Form1 form_Client = new Form1();
            form_Client.ShowDialog();
            
        }
        private void button_Order_Click(object sender, EventArgs e)
        {
            Form_Order form_Order = new Form_Order();
            form_Order.ShowDialog();

        }
        private void button_Product_Click(object sender, EventArgs e)
        {
            Form_Products form_Product = new Form_Products();
            form_Product.ShowDialog();

        }
        private void button_Accessory_Click(object sender, EventArgs e)
        {
            Form_Accessories form_Accessories = new Form_Accessories();
            form_Accessories.ShowDialog();

        }
        private void button_Reports_Click(object sender, EventArgs e)
        {
            Report form_Report = new Report();
            form_Report.ShowDialog();

        }
    }
}
