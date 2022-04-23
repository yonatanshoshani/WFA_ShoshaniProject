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
    public partial class Form_CategoryAccessories : Form
    {
        public CategoryAccessories SelectedCategoryAccessories { get => listBox_CategoryAccessories.SelectedItem as CategoryAccessories; }
        public Form_CategoryAccessories(CategoryAccessories CategoryAccessories = null)
        {
            InitializeComponent();
            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (CategoryAccessories != null && CategoryAccessories.Id <= 0)
                CategoryAccessories = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CategoryAccessoriesArrToForm(CategoryAccessories);
            CategoryAccessoriesToForm(CategoryAccessories);
        }

        private void Form_CategoryAccessories_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
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
                CategoryAccessories CategoryAccessories = FormToCategoryAccessories();

                if (CategoryAccessories.Id == 0)
                {
                    CategoryAccessoriesArr oldCategoryAccessoriesArr = new CategoryAccessoriesArr();
                    oldCategoryAccessoriesArr.Fill();
                    if (!oldCategoryAccessoriesArr.IsContains(CategoryAccessories.Name))
                    {
                        if (CategoryAccessories.Insert())
                        {
                            

                            CategoryAccessoriesArr CategoryAccessoriesArr = new CategoryAccessoriesArr();
                            CategoryAccessoriesArr.Fill();
                            CategoryAccessories = CategoryAccessoriesArr.GetCategoryAccessoriesWithMaxId();
                            MessageBox.Show("Ok");

                            //עדכון תיבת הרשימה

                            CategoryAccessoriesArrToForm(CategoryAccessories);
                        }
                        else
                            MessageBox.Show("Not Ok");

                    }
                    else
                        MessageBox.Show("Already exist");
                }
                else
                {


                    if (CategoryAccessories.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        CategoryAccessoriesArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                CategoryAccessoriesArrToForm();
            }

        }

        private CategoryAccessories FormToCategoryAccessories()
        {
            CategoryAccessories CategoryAccessories = new CategoryAccessories();
            CategoryAccessories.Name = textBox_Name.Text;
            if (label_ID.Text != "")
                CategoryAccessories.Id = int.Parse(label_ID.Text);

            return CategoryAccessories;

        }

        private void CategoryAccessoriesArrToForm(CategoryAccessories curCategoryAccessories = null)
        {
            

            CategoryAccessoriesArr CategoryAccessoriesArr = new CategoryAccessoriesArr();
            CategoryAccessoriesArr.Fill();
            listBox_CategoryAccessories.DataSource = CategoryAccessoriesArr;
            listBox_CategoryAccessories.ValueMember = "Id";
            listBox_CategoryAccessories.DisplayMember = "Name";

            //א

            if (curCategoryAccessories != null)
                listBox_CategoryAccessories.SelectedValue = curCategoryAccessories.Id;

        }

        private void CategoryAccessoriesToForm(CategoryAccessories CategoryAccessories= null)
        {
            if (CategoryAccessories != null)
            {
                label_ID.Text = CategoryAccessories.Id.ToString();
                textBox_Name.Text = CategoryAccessories.Name;

            }
            else
            {
                label_ID.Text = "0";
                textBox_Name.Text = "";

            }
        }

        private void listBox_CategoryAccessories_DoubleClick(object sender, EventArgs e)
        {
            CategoryAccessoriesToForm(listBox_CategoryAccessories.SelectedItem as CategoryAccessories);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            CategoryAccessoriesToForm(null);
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (label_ID.Text == "0")
                MessageBox.Show("You must select a CategoryAccessories");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    CategoryAccessories CategoryAccessories = FormToCategoryAccessories();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    AccessoriesArr AccessoriesArr = new AccessoriesArr();
                    AccessoriesArr.Fill();
                    if (AccessoriesArr.DoesExist(CategoryAccessories))
                        MessageBox.Show("You can’t delete a CategoryAccessories that is related to a Accessories");
                    else
                    if (CategoryAccessories.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CategoryAccessoriesToForm(null);
                        CategoryAccessoriesArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }

        }

        private void Form_CategoryAccessories_Load(object sender, EventArgs e)
        {

        }
    }
}
