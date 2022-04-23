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

namespace WFA_ShoshaniProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CapsLockCheck();
            Form_Client_InputLanguageChanged(null,null);
            ClientArrToForm();
            CityArrToForm();
           
        }

        private void Form_Client_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
                MessageBox.Show("Please switch to english");

        }
        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("You are on CapsLock");
        }

        private void textBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
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

            if(textBox_FirstName.Text.Length < 2)
            {
                flag = false;
                textBox_FirstName.BackColor = Color.Red;
            }
            else
                textBox_FirstName.BackColor = Color.White;

            if(textBox_LastName.Text.Length < 2)
            {
                flag = false;
                textBox_LastName.BackColor = Color.Red;
            }
            else
                textBox_LastName.BackColor = Color.White;

            if (textBox_ID.Text.Length != 9)
            {
                flag = false;
                textBox_ID.BackColor = Color.Red;
            }
            else
                textBox_ID.BackColor = Color.White;

            if (textBox_Phone.Text.Length != 7)
            {
                flag = false;
                textBox_Phone.BackColor = Color.Red;
            }
            else
                textBox_Phone.BackColor = Color.White;

            if (textBox_Email.Text.Length < 6)
            {
                flag = false;
                textBox_Email.BackColor = Color.Red;
            }
            else
                textBox_Email.BackColor = Color.White;
            try
            {
                new System.Net.Mail.MailAddress(textBox_Email.Text);
            }
            catch (ArgumentException)
            {
                //textBox is empty
            }
            catch (FormatException)
            {
                //textBox contains no valid mail address
            }
            if((int)comboBox_City.SelectedValue < 0)
            {
                flag = false;
                comboBox_City.ForeColor = Color.Red;
            }
            else
                comboBox_City.ForeColor = Color.White;
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
                Client client = FormToClient();
                
                if (client.ID == 0)
                {
                    if (client.Insert())
                    {
                        MessageBox.Show("Added successfully");
                    }
                    else
                        MessageBox.Show("Error adding");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (client.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        ClientArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                ClientArrToForm();
            }

        }
        private Client FormToClient()
        {
            Client client = new Client();
            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            if(label_Id.Text!="")
                client.ID = int.Parse(label_Id.Text);
            client.Email = textBox_Email.Text;
            client.Tz = textBox_ID.Text;
            client.PhoneNumber = comoBox_threedigits.Text + textBox_Phone.Text;
            client.city = comboBox_City.SelectedItem as City;

            return client;

        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox);
            if (textBox.Text.Length < 2)
                textBox.BackColor = Color.Red;
            else
                textBox.BackColor = Color.White;

        }
        private void ClientArrToForm()
        {
            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
            
        }
        private void ClientToForm(Client client)
        {
            if (client != null)
            {
                label_Id.Text = client.ID.ToString();
                textBox_FirstName.Text = client.FirstName;
                textBox_LastName.Text = client.LastName;
                textBox_Email.Text = client.Email;
                textBox_ID.Text = client.Tz;
                comoBox_threedigits.SelectedItem = client.PhoneNumber.Substring(0, 3);
                textBox_Phone.Text = client.PhoneNumber.Substring(3);
                comboBox_City.SelectedValue = client.city.Id;
            }
            else
            {
               label_Id.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_Phone.Text = "";
                comoBox_threedigits.Text = "";
                textBox_Email.Text = "";
                textBox_ID.Text = "";
                comboBox_City.SelectedItem = null;
            }
        }

        public void CityArrToForm(City curCity= null)
        {

            //ממירה את הטנ "מ אוסף ישובים לטופס

            CityArr cityArr = new CityArr();
            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            City cityDefault = new City();
            cityDefault.Id = -1;
            cityDefault.Name = "בחר ישוב";

            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            cityArr.Add(cityDefault);

            cityArr.Fill();

            comboBox_City.DataSource = cityArr;
            comboBox_City.ValueMember = "Id";
            comboBox_City.DisplayMember = "Name";
            if (curCity != null)
                comboBox_City.SelectedValue = curCity.Id;
        }
        private void listBox_Client_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Clients.SelectedItem as Client);
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_FilterId.Text != "")
                id = int.Parse(textBox_FilterId.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(id, textBox_FilterLastName.Text,
            textBox_FilterCell.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClientToForm(null);
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            Client client = FormToClient();
            if (client.ID == 0)
                MessageBox.Show("You need to choose a client");
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (client.Delete())
                    {
                        MessageBox.Show("succesfully deleted");

                    }
                    else
                    {
                        MessageBox.Show("There was a problem with deleting this user");
                    }
                        ClientToForm(null);
                    ClientArrToForm();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_City_Click(object sender, EventArgs e)
        {
            Form_City form_City = new Form_City(comboBox_City.SelectedItem as City);
            form_City.ShowDialog();
            CityArrToForm(form_City.SelectedCity);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
