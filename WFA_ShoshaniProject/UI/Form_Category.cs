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
    public partial class Form_Category : Form
    {
        public Category SelectedCategory { get => listBox_Category.SelectedItem as Category; }
        public Form_Category(Category Category = null)
        {
            InitializeComponent();
            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (Category != null && Category.Id <= 0)
                Category = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CategoryArrToForm(Category);
            CategoryToForm(Category);
        }

        private void Form_Category_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
                MessageBox.Show("Please switch to english");

        }
        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("You are on CapsLock");
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
                Category Category = FormToCategory();

                if (Category.Id == 0)
                {
                    CategoryArr oldCategoryArr = new CategoryArr();
                    oldCategoryArr.Fill();
                    if (!oldCategoryArr.IsContains(Category.Name))
                    {
                        if (Category.Insert())
                        {
                            //כיוון שמדובר על ישוב חדש, ניעזר במזהה הגבוה ביותר = הישוב האחרון שנוסף לטבלה

                            CategoryArr CategoryArr = new CategoryArr();
                            CategoryArr.Fill();
                            Category = CategoryArr.GetCategoryWithMaxId();
                            MessageBox.Show("Ok");

                            //עדכון תיבת הרשימה

                            CategoryArrToForm(Category);
                        }
                        else
                            MessageBox.Show("Not Ok");

                    }
                    else
                        MessageBox.Show("Already exist");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (Category.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        CategoryArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                CategoryArrToForm();
            }

        }

        private Category FormToCategory()
        {
            Category Category = new Category();
            Category.Name = textBox_Name.Text;
            if (label_ID.Text != "")
                Category.Id = int.Parse(label_ID.Text);

            return Category;

        }

        private void CategoryArrToForm(Category curCategory = null)
        {
            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CategoryArr CategoryArr = new CategoryArr();
            CategoryArr.Fill();
            listBox_Category.DataSource = CategoryArr;
            listBox_Category.ValueMember = "Id";
            listBox_Category.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCategory != null)
                listBox_Category.SelectedValue = curCategory.Id;

        }

        private void CategoryToForm(Category Category)
        {
            if (Category != null)
            {
                label_ID.Text = Category.Id.ToString();
                textBox_Name.Text = Category.Name;

            }
            else
            {
                label_ID.Text = "0";
                textBox_Name.Text = "";

            }
        }

        private void listBox_Category_DoubleClick(object sender, EventArgs e)
        {
            CategoryToForm(listBox_Category.SelectedItem as Category);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            CategoryToForm(null);
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (label_ID.Text == "0")
                MessageBox.Show("You must select a Category");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Category category = FormToCategory();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    if (productArr.DoesExist(category))
                        MessageBox.Show("You can’t delete a Category that is related to a Product");
                    else
                    if (category.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CategoryToForm(null);
                        CategoryArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }

        }

        private void Form_Category_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
