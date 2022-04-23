using WFA_ShoshaniProject.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ShoshaniProject.UI
{
    public partial class Form_CompanyAccessories : Form
    {
        
        public Form_CompanyAccessories(CompanyAccessories CompanyAccessories = null)
        {
            InitializeComponent();

            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (CompanyAccessories != null && CompanyAccessories.Id <= 0)
                CompanyAccessories = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CompanyAccessoriesArrToForm(CompanyAccessories);
            CompanyAccessoriesToForm(CompanyAccessories);
            CapsLockCheck();
            Form_CompanyAccessories_InputLanguageChanged(null, null);
        }

        private void Form_CompanyAccessories_Load(object sender, EventArgs e)
        {

        }

        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("You have CapsLock on.");
        }

        private void Form_CompanyAccessories_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
                MessageBox.Show("Your language is not English.");
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private bool IsEngLetter(char C)
        {
            return (C >= 'a' && C <= 'z') || (C >= 'A' && C <= 'Z');
        }

        private bool CheckForm()
        {
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

        private CompanyAccessories FormToCompanyAccessories()
        {
            CompanyAccessories CompanyAccessories = new CompanyAccessories
            {
                Name = textBox_Name.Text,
                Id = int.Parse(label_ID.Text)
            };

            return CompanyAccessories;

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                CompanyAccessories CompanyAccessories = FormToCompanyAccessories();

                if (CompanyAccessories.Id == 0)
                {
                    //בדיקה האם היישוב קיים כבר

                    CompanyAccessoriesArr oldCompanyAccessoriesArr = new CompanyAccessoriesArr();
                    oldCompanyAccessoriesArr.Fill();
                    if (!oldCompanyAccessoriesArr.IsContains(CompanyAccessories.Name))
                    {
                        if (CompanyAccessories.Insert())
                        {
                            MessageBox.Show("Form filled successfully", "Yay!", MessageBoxButtons.OK);

                            //עדכון תיבת הרשימה
                            CompanyAccessoriesArr CompanyAccessoriesArr = new CompanyAccessoriesArr();
                            CompanyAccessoriesArr.Fill();
                            CompanyAccessories = CompanyAccessoriesArr.GetCompanyAccessoriesWithMaxId();
                            CompanyAccessoriesArrToForm();
                        }
                        else
                            MessageBox.Show("Error adding", "Error", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                        MessageBox.Show("This CompanyAccessories already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                else
                {
                    if (CompanyAccessories.Update())
                        MessageBox.Show("Updated successfully", "Yay!", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Error updating", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                CompanyAccessoriesArrToForm(CompanyAccessories);
            }
        }

        private void CompanyAccessoriesArrToForm(CompanyAccessories curCompanyAccessories = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CompanyAccessoriesArr CompanyAccessoriesArr = new CompanyAccessoriesArr();
            CompanyAccessoriesArr.Fill();
            listBox_CompaniesAccessories.DataSource = CompanyAccessoriesArr;
            listBox_CompaniesAccessories.ValueMember = "Id";
            listBox_CompaniesAccessories.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCompanyAccessories != null)
                listBox_CompaniesAccessories.SelectedValue = curCompanyAccessories.Id;
        }



        private void CompanyAccessoriesToForm(CompanyAccessories CompanyAccessories= null)
        {
            if (CompanyAccessories != null)
            {
                //ממירה את המידע בטנ"מ לקוח 
                label_ID.Text = CompanyAccessories.Id.ToString();
                textBox_Name.Text = CompanyAccessories.Name;
            }

            else
            {
                label_ID.Text = "0";
                textBox_Name.Text = "";
            }

        }
        private void listBox_CompanyAccessories_DoubleClick(object sender, EventArgs e)
        {
            CompanyAccessoriesToForm(listBox_CompaniesAccessories.SelectedItem as CompanyAccessories);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CompanyAccessoriesToForm(null);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CompanyAccessories CompanyAccessories = FormToCompanyAccessories();
            if (CompanyAccessories.Id == 0)
                MessageBox.Show("You need to choose a CompanyAccessories");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    AccessoriesArr AccessoriesArr = new AccessoriesArr();
                    AccessoriesArr.Fill();
                    if (AccessoriesArr.DoesExist(CompanyAccessories))
                        MessageBox.Show("You can’t delete a CompanyAccessories that is related to a Accessories");
                    else
                     if (CompanyAccessories.Delete())
                    {
                        MessageBox.Show("CompanyAccessories deleted successfully!", "Yay!", MessageBoxButtons.OK);
                        CompanyAccessoriesToForm(null);
                        CompanyAccessoriesArrToForm();
                    }
                    else
                        MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }




    }
}