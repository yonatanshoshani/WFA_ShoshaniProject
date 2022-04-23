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
    public partial class Form_City : Form
    {
        public City SelectedCity { get => listBox_City.SelectedItem as City; }
        public Form_City(City city= null)
        {
            InitializeComponent();
            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (city != null && city.Id <= 0)
                city = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CityArrToForm(city);
            CityToForm(city);
        }

        private void Form_City_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
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
                City City = FormToCity();

                if (City.Id == 0)
                {
                    CityArr oldCityArr = new CityArr();
                    oldCityArr.Fill();
                    if (!oldCityArr.IsContains(City.Name))
                    {
                        if (City.Insert())
                        {
                            //כיוון שמדובר על ישוב חדש, ניעזר במזהה הגבוה ביותר = הישוב האחרון שנוסף לטבלה

                            CityArr cityArr = new CityArr();
                            cityArr.Fill();
                            City = cityArr.GetCityWithMaxId();
                            MessageBox.Show("Ok");

                            //עדכון תיבת הרשימה

                            CityArrToForm(City);
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

                    if (City.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        CityArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                CityArrToForm();
            }

        }

        private City FormToCity()
        {
            City City = new City();
            City.Name = textBox_Name.Text;
            if (label_Id.Text != "")
                City.Id = int.Parse(label_Id.Text);

            return City;

        }

        private void CityArrToForm(City curCity= null)
        {
            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CityArr CityArr = new CityArr();
            CityArr.Fill();
            listBox_City.DataSource = CityArr;
            listBox_City.ValueMember = "Id";
            listBox_City.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCity != null)
                listBox_City.SelectedValue = curCity.Id;

        }

        private void CityToForm(City City)
        {
            if (City != null)
            {
                label_Id.Text = City.Id.ToString();
                textBox_Name.Text = City.Name;

            }
            else
            {
                label_Id.Text = "0";
                textBox_Name.Text = "";

            }
        }

        private void listBox_City_DoubleClick(object sender, EventArgs e)
        {
            CityToForm(listBox_City.SelectedItem as City);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            CityToForm(null);
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (label_Id.Text == "0")
                MessageBox.Show("You must select a city");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    City city = FormToCity();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(city))
                        MessageBox.Show("You can’t delete a city that is related to a client");
                    else
                    if (city.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CityToForm(null);
                        CityArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }

        }

        private void Form_City_Load(object sender, EventArgs e)
        {

        }
    }
}
