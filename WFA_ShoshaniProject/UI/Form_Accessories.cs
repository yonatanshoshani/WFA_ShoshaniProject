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

namespace WFA_ShoshaniProject.UI
{
    public partial class Form_Accessories : Form
    {
        public Form_Accessories()
        {
            InitializeComponent();
            CapsLockCheck();
            Form_Accessories_InputLanguageChanged(null, null);
            AccessoriesArrToForm();
            CompanyAccessoriesArrToForm1();
            CompanyArrToForm();
            CategoryArrToForm();
            CategoryArrToForm1();
           // SetProductsByFilter();


        }

        private void Form_Accessories_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
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

            if ((int)comboBox_CompanyAccessories.SelectedValue < 0)
            {
                flag = false;
                comboBox_CompanyAccessories.ForeColor = Color.Red;
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
                Accessories Accessories = FormToAccessories();

                if (Accessories.Id == 0)
                {
                    if (Accessories.Insert())
                    {
                        MessageBox.Show("Added successfully");
                    }
                    else
                        MessageBox.Show("Error adding");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (Accessories.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        AccessoriesArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                AccessoriesArrToForm();
            }

        }
        private Accessories FormToAccessories()
        {
            Accessories Accessories = new Accessories();
            Accessories.Name = textBox_Name.Text;
            if (label_ID.Text != "")
                Accessories.Id = int.Parse(label_ID.Text);
            Accessories.Company = comboBox_CompanyAccessories.SelectedItem as Company;
            Accessories.Category = comboBox_Category.SelectedItem as Category;

            return Accessories;

        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (textBox.Text.Length < 2)
                textBox.BackColor = Color.Red;
            else
                textBox.BackColor = Color.White;

        }
        private void AccessoriesArrToForm()
        {
            //ממירה את הטנ "מ אוסף לקוחות לטופס

            AccessoriesArr AccessoriesArr = new AccessoriesArr();
            AccessoriesArr.Fill();
            listBox_Accessories.DataSource = AccessoriesArr;

        }
        private void AccessoriesToForm(Accessories Accessories)
        {
            if (Accessories != null)
            {
                label_ID.Text = Accessories.Id.ToString();
                textBox_Name.Text = Accessories.Name;
                comboBox_CompanyAccessories.SelectedValue = Accessories.Company.Id;
                comboBox_Category.SelectedValue = Accessories.Category.Id;
                numericUpDown1.Value = Accessories.Count;
            }
            else
            {
                label_ID.Text = "0";
                textBox_Name.Text = "";
                comboBox_CompanyAccessories.SelectedItem = null;
                comboBox_Category.SelectedItem = null;
                numericUpDown1.Value = 0;
            }
        }

        public void CompanyAccessoriesArrToForm(CompanyAccessories curCompanyAccessories = null)
        {

            //ממירה את הטנ "מ אוסף ישובים לטופס

            CompanyAccessoriesArr CompanyAccessoriesArr = new CompanyAccessoriesArr();
            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            CompanyAccessories CompanyAccessoriesDefault = new CompanyAccessories();
            CompanyAccessoriesDefault.Id = -1;
            CompanyAccessoriesDefault.Name = "בחר ישוב";

            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            CompanyAccessoriesArr.Add(CompanyAccessoriesDefault);

            CompanyAccessoriesArr.Fill();

            comboBox_CompanyAccessories.DataSource = CompanyAccessoriesArr;
            comboBox_CompanyAccessories.ValueMember = "Id";
            comboBox_CompanyAccessories.DisplayMember = "Name";
            if (curCompanyAccessories != null)
                comboBox_CompanyAccessories.SelectedValue = curCompanyAccessories.Id;
        }
        private void listBox_Accessories_DoubleClick(object sender, EventArgs e)
        {
            AccessoriesToForm(listBox_Accessories.SelectedItem as Accessories);
        }

        public void CategoryArrToForm(ComboBox comboBox, bool isMustChoose, CategoryAccessories curCategory = null)
        {
            CategoryAccessoriesArr CategoryAccessoriesArr = new CategoryAccessoriesArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            CategoryAccessories categoryAccessoriesDefault = new CategoryAccessories();
            categoryAccessoriesDefault.Id = -1;
            if (isMustChoose)
                categoryAccessoriesDefault.Name = "Choose a category";
            else
                categoryAccessoriesDefault.Name = "All categories";
            CategoryAccessoriesArr.Add(categoryAccessoriesDefault);
            CategoryAccessoriesArr.Fill();
            comboBox.DataSource = "u/categoryAccessoriesArr";
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCategory != null)
                comboBox.SelectedValue = curCategory.Id;
        }

        //private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        //{

        //    //מייצרים אוסף של כלל הלקוחות

        //    AccessoriesArr AccessoriesArr = new AccessoriesArr();
        //    AccessoriesArr.Fill();

        //    //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

        //    AccessoriesArr = AccessoriesArr.Filter(textBox_NameFilter.Text,
        //    comboBox_CompanyFilter.SelectedItem as Company, comboBox_CategoryFilter.SelectedItem as Category);
        //    //מציבים בתיבת הרשימה את אוסף הלקוחות

        //    listBox_Accessories.DataSource = AccessoriesArr;
        //}

        private void button_Clear_Click(object sender, EventArgs e)
        {
            AccessoriesToForm(null);
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            Accessories Accessories = FormToAccessories();
            if (Accessories.Id == 0)
                MessageBox.Show("You need to choose a Accessories");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (Accessories.Delete())
                    {
                        MessageBox.Show("succesfully deleted");

                    }
                    else
                    {
                        MessageBox.Show("There was a problem with deleting this user");
                    }
                    AccessoriesToForm(null);
                    AccessoriesArrToForm();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Company_Click(object sender, EventArgs e)
        {
            Form_CompanyAccessories form_Company = new Form_CompanyAccessories(comboBox_CompanyAccessories.SelectedItem as CompanyAccessories);
            form_Company.ShowDialog();
  
        }
        private void button_Category_Click(object sender, EventArgs e)
        {
            Form_CategoryAccessories form_Category = new Form_CategoryAccessories(comboBox_Category.SelectedItem as CategoryAccessories);
            form_Category.ShowDialog();

        }

        private void Form_Accessories_Load(object sender, EventArgs e)
        {

        }

        private void label_Name1_Click(object sender, EventArgs e)
        {

        }
        public void CompanyArrToForm(CompanyAccessories curCompany = null)
        {
            CompanyAccessoriesArr CompanyAccessoriesArr = new CompanyAccessoriesArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            CompanyAccessories CompanyAccessoriesDefault = new CompanyAccessories();
            CompanyAccessoriesDefault.Id = -1;
            CompanyAccessoriesDefault.Name = "All companies";
            CompanyAccessoriesArr.Add(CompanyAccessoriesDefault);
            CompanyAccessoriesArr.Fill();
            comboBox_CompanyAccessories.DataSource = CompanyAccessoriesArr;
            comboBox_CompanyAccessories.ValueMember = "Id";
            comboBox_CompanyAccessories.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCompany != null)
                comboBox_CompanyAccessories.SelectedValue = curCompany.Id;
        }
        public void CategoryArrToForm(CategoryAccessories curCategoryAccessories = null)
        {
            CategoryAccessoriesArr categoryAccessoriesArr = new CategoryAccessoriesArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            CategoryAccessories categoryAccessoriesDefault = new CategoryAccessories();
            categoryAccessoriesDefault.Id = -1;

            categoryAccessoriesDefault.Name = "All categories";
            categoryAccessoriesArr.Add(categoryAccessoriesDefault);
            categoryAccessoriesArr.Fill();
            comboBox_Category.DataSource = categoryAccessoriesArr;
            comboBox_Category.ValueMember = "Id";
            comboBox_Category.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCategoryAccessories != null)
                comboBox_Category.SelectedValue = curCategoryAccessories.Id;
        }
        public void CompanyAccessoriesArrToForm1(CompanyAccessories curCompanyAccessories = null)
        {
            CompanyAccessoriesArr CompanyAccessoriesArr = new CompanyAccessoriesArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            CompanyAccessories CompanyAccessoriesDefault = new CompanyAccessories();
            CompanyAccessoriesDefault.Id = -1;
            CompanyAccessoriesDefault.Name = "All companies";
            CompanyAccessoriesArr.Add(CompanyAccessoriesDefault);
            CompanyAccessoriesArr.Fill();
            comboBox_CompanyFilter.DataSource = CompanyAccessoriesArr;
            comboBox_CompanyFilter.ValueMember = "Id";
            comboBox_CompanyFilter.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCompanyAccessories != null)
                comboBox_CompanyFilter.SelectedValue = curCompanyAccessories.Id;
        }
        public void CategoryArrToForm1(CategoryAccessories curCategoryAccessories = null)
        {
            CategoryAccessoriesArr categoryAccessoriesArr = new CategoryAccessoriesArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            CategoryAccessories categoryAccessoriesDefault = new CategoryAccessories();
            categoryAccessoriesDefault.Id = -1;

            categoryAccessoriesDefault.Name = "All categories";
            categoryAccessoriesArr.Add(categoryAccessoriesDefault);
            categoryAccessoriesArr.Fill();
            comboBox_CategoryFilter.DataSource = categoryAccessoriesArr;
            comboBox_CategoryFilter.ValueMember = "Id";
            comboBox_CategoryFilter.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCategoryAccessories != null)
                comboBox_CategoryFilter.SelectedValue = curCategoryAccessories.Id;
        }
        private void SetAccessoriesByFilter()
        {

            //מייצרים אוסף של כלל המוצרים

            AccessoriesArr accessoriesArr = new AccessoriesArr();
            accessoriesArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            accessoriesArr = accessoriesArr.Filter(textBox_NameFilter.Text,
            comboBox_CompanyFilter.SelectedItem as CompanyAccessories,
            comboBox_CategoryFilter.SelectedItem as CategoryAccessories);

            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_Accessories.DataSource = accessoriesArr;
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetAccessoriesByFilter();
        }
    }
}
