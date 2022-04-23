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
    public partial class Form_Company : Form
    {
        public Company SelectedCompany { get => listBox_Data.SelectedItem as Company; }
        public Form_Company(Company company = null)
        {
            InitializeComponent();

            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (company != null && company.Id <= 0)
                company = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CompanyArrToForm(company);
            CompanyToForm(company);
            CapsLockCheck();
            Form_Company_InputLanguageChanged(null, null);
        }

        private void Form_Company_Load(object sender, EventArgs e)
        {

        }

        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("You have CapsLock on.");
        }

        private void Form_Company_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
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

        private Company FormToCompany()
        {
            Company company = new Company
            {
                Name = textBox_Name.Text,
                Id = int.Parse(label_ID.Text)
            };

            return company;

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
                Company company = FormToCompany();

                if (company.Id == 0)
                {
                    //בדיקה האם היישוב קיים כבר

                    CompanyArr oldCompanyArr = new CompanyArr();
                    oldCompanyArr.Fill();
                    if (!oldCompanyArr.IsContains(company.Name))
                    {
                        if (company.Insert())
                        {
                            MessageBox.Show("Form filled successfully", "Yay!", MessageBoxButtons.OK);

                            //עדכון תיבת הרשימה
                            CompanyArr companyArr = new CompanyArr();
                            companyArr.Fill();
                            company = companyArr.GetCompanyWithMaxId();
                            CompanyArrToForm();
                        }
                        else
                            MessageBox.Show("Error adding", "Error", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                        MessageBox.Show("This company already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                else
                {
                    if (company.Update())
                        MessageBox.Show("Updated successfully", "Yay!", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Error updating", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                CompanyArrToForm(company);
            }
        }

        private void CompanyArrToForm(Company curCompany = null)
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CompanyArr companyArr = new CompanyArr();
            companyArr.Fill();
            listBox_Data.DataSource = companyArr;
            listBox_Data.ValueMember = "Id";
            listBox_Data.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCompany != null)
                listBox_Data.SelectedValue = curCompany.Id;
        }



        private void CompanyToForm(Company company)
        {
            if (company != null)
            {
                //ממירה את המידע בטנ"מ לקוח 
                label_ID.Text = company.Id.ToString();
                textBox_Name.Text = company.Name;
            }

            else
            {
                label_ID.Text = "0";
                textBox_Name.Text = "";
            }

        }
        private void listBox_Company_DoubleClick(object sender, EventArgs e)
        {
            CompanyToForm(listBox_Data.SelectedItem as Company);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CompanyToForm(null);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Company company = FormToCompany();
            if (company.Id == 0)
                MessageBox.Show("You need to choose a company");
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

                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    if (productArr.DoesExist(company))
                        MessageBox.Show("You can’t delete a company that is related to a product");
                    else
                     if (company.Delete())
                    {
                        MessageBox.Show("Company deleted successfully!", "Yay!", MessageBoxButtons.OK);
                        CompanyToForm(null);
                        CompanyArrToForm();
                    }
                    else
                        MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }




    }
}