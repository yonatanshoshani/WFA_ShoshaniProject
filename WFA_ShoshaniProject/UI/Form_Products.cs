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
using WFA_ShoshaniProject.UI;
using WFA_ShoshaniProject.DAL;

namespace WFA_ShoshaniProject.UI
{
    public partial class Form_Products : Form
    {
        public Form_Products()
        {
            InitializeComponent();
            CapsLockCheck();
            Form_Product_InputLanguageChanged(null, null);
            ProductArrToForm();
            CompanyArrToForm();
            CategoryArrToForm();
            CompanyArrToForm1();
            CategoryArrToForm1();

        }

        private void Form_Product_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
                MessageBox.Show("Please switch to english");

        }
        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("You are on CapsLock");
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }
        private void textBox_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }
        private bool IsEngLetter(char c)
        {
            return !((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));

        }
        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            if (textBox_Name.Text.Length < 2)
            {
                flag = false;
                textBox_Name.BackColor = Color.Red;
            }
            else
                textBox_Name.BackColor = Color.White;

            if ((int)comboBox_Company.SelectedValue < 0)
            {
                flag = false;
                comboBox_Company.ForeColor = Color.Red;
            }
            else
                comboBox_Category.ForeColor = Color.White;

            if ((int)comboBox_Category.SelectedValue < 0)
            {
                flag = false;
                comboBox_Category.ForeColor = Color.Red;
            }
            else
                comboBox_Category.ForeColor = Color.White;
            return flag;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading |
                MessageBoxOptions.RightAlign);
            }
            else
            {
                Product product = FormToProduct();

                if (product.Id == 0)
                {
                    if (product.Insert())
                    {
                        MessageBox.Show("Added successfully");
                    }
                    else
                        MessageBox.Show("Error adding");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (product.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        ProductArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                ProductArrToForm();
            }

        }
        private Product FormToProduct()
        {
            Product product = new Product();
            product.Name = textBox_Name.Text;
            if (label_Id.Text != "")
                product.Id = int.Parse(label_Id.Text);
            product.Company = comboBox_Company.SelectedItem as Company;
            product.Category = comboBox_Category.SelectedItem as Category;
            product.Count = (int)numericUpDown2.Value;

            return product;

        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (textBox.Text.Length < 2)
                textBox.BackColor = Color.Red;
            else
                textBox.BackColor = Color.White;

        }
        private void ProductArrToForm()
        {
            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ProductArr ProductArr = new ProductArr();
            ProductArr.Fill();
            listBox_Products.DataSource = ProductArr;

        }
        private void ProductToForm(Product Product)
        {
            if (Product != null)
            {
                label_Id.Text = Product.Id.ToString();
                textBox_Name.Text = Product.Name;
                comboBox_Company.SelectedValue = Product.Company.Id;
                comboBox_Category.SelectedValue = Product.Category.Id;
                numericUpDown2.Value = Product.Count;
            }
            else
            {
                label_Id.Text = "0";
                textBox_Name.Text = "";
                comboBox_Company.SelectedItem = null;
                comboBox_Category.SelectedItem = null;
                numericUpDown2.Value = 0;
            }
        }

        private void listBox_Product_DoubleClick(object sender, EventArgs e)
        {
            ProductToForm(listBox_Products.SelectedItem as Product);
        }
        public void CompanyArrToForm(Company curCompany = null)
        {
            CompanyArr companyArr = new CompanyArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Company companyDefault = new Company();
            companyDefault.Id = -1;
            companyDefault.Name = "All companies";
            companyArr.Add(companyDefault);
            companyArr.Fill();
            comboBox_Company.DataSource = companyArr;
            comboBox_Company.ValueMember = "Id";
            comboBox_Company.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCompany != null)
                comboBox_Company.SelectedValue = curCompany.Id;
        }
        public void CategoryArrToForm(Category curCategory = null)
        {
            CategoryArr categoryArr = new CategoryArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Category categoryDefault = new Category();
            categoryDefault.Id = -1;

            categoryDefault.Name = "All categories";
            categoryArr.Add(categoryDefault);
            categoryArr.Fill();
            comboBox_Category.DataSource = categoryArr;
            comboBox_Category.ValueMember = "Id";
            comboBox_Category.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCategory != null)
                comboBox_Category.SelectedValue = curCategory.Id;
        }
        public void CompanyArrToForm1(Company curCompany = null)
        {
            CompanyArr companyArr = new CompanyArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Company companyDefault = new Company();
            companyDefault.Id = -1;
            companyDefault.Name = "All companies";
            companyArr.Add(companyDefault);
            companyArr.Fill();
            comboBox_CompanyFilter.DataSource = companyArr;
            comboBox_CompanyFilter.ValueMember = "Id";
            comboBox_CompanyFilter.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCompany != null)
                comboBox_CompanyFilter.SelectedValue = curCompany.Id;
        }
        public void CategoryArrToForm1(Category curCategory = null)
        {
            CategoryArr categoryArr = new CategoryArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Category categoryDefault = new Category();
            categoryDefault.Id = -1;

            categoryDefault.Name = "All categories";
            categoryArr.Add(categoryDefault);
            categoryArr.Fill();
            comboBox_CategoryFilter.DataSource = categoryArr;
            comboBox_CategoryFilter.ValueMember = "Id";
            comboBox_CategoryFilter.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCategory != null)
                comboBox_CategoryFilter.SelectedValue = curCategory.Id;
        }
        private void SetProductsByFilter()
        {

            //מייצרים אוסף של כלל המוצרים

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(textBox_NameFilter.Text,
            comboBox_CompanyFilter.SelectedItem as Company,
            comboBox_CategoryFilter.SelectedItem as Category);



            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_Products.DataSource = productArr;
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {

            //מייצרים אוסף של כלל הלקוחות

            ProductArr ProductArr = new ProductArr();
            ProductArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            ProductArr = ProductArr.Filter(textBox_NameFilter.Text,
            comboBox_CompanyFilter.SelectedItem as Company, comboBox_CategoryFilter.SelectedItem as Category);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Products.DataSource = ProductArr;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ProductToForm(null);
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            Product Product = FormToProduct();
            if (Product.Id == 0)
                MessageBox.Show("You need to choose a Product");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (Product.Delete())
                    {
                        MessageBox.Show("succesfully deleted");

                    }
                    else
                    {
                        MessageBox.Show("There was a problem with deleting this user");
                    }
                    ProductToForm(null);
                    ProductArrToForm();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Company_Click(object sender, EventArgs e)
        {
            Form_Company form_Company = new Form_Company(comboBox_Company.SelectedItem as Company);
            form_Company.ShowDialog();
            CompanyArrToForm(form_Company.SelectedCompany);
        }
        private void button_Category_Click(object sender, EventArgs e)
        {
            Form_Category form_Category = new Form_Category(comboBox_Category.SelectedItem as Category);
            form_Category.ShowDialog();
            CategoryArrToForm(form_Category.SelectedCategory);
        }

        private void Form_Products_Load(object sender, EventArgs e)
        {

        }

        private void label_Name1_Click(object sender, EventArgs e)
        {

        }
    }
}
