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
using WFA_ShoshaniProject.UI;
using WFA_ShoshaniProject.DAL;


namespace WFA_ShoshaniProject.UI
{
    public partial class Form_Order : Form
    {
        public Form_Order()
        {


            InitializeComponent();
            ClientArrToForm();
            OrderArrToForm();
            ProductArrToForm(listBox_PotentialProducts);
            AccessoryArrToForm(listBox_PotentialAccessories);
            CompanyArrToForm();
            CategoryArrToForm();
            CompanyAccessoriesArrToForm();
            CategoryAccessoriesArrToForm();
            CapsLockCheck();
            Form_Order_InputLanguageChanged(null, null);
            OrderToForm(null);
            //AccessoryArrToForm(listBox_PotentialAccessories);
        }

        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("You have CapsLock on.");
        }

        private void Form_Order_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            if (InputLanguage.CurrentInputLanguage.Culture.Name.ToLower() != "en-us")
                MessageBox.Show("Your language is not English.");
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {

        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private bool IsEngLetter(char C)
        {
            return (C >= 'a' && C <= 'z') || (C >= 'A' && C <= 'Z');
        }
        //private void Order_dateTimePicker_ValueChanged(object sender, EventArgs e)
        //{
        //    SetOrderByFilter();
        //}

        //private void Order_textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        //{
        //    SetOrderByFilter();
        //}
        //public OrderArr Filter(int id, Client client, DateTime from, DateTime to)
        //{
        //    OrderArr orderArr = new OrderArr();

        //    for (int i = 0; i < this.Count; i++)
        //    {

        //        //הצבת המוצר הנוכחי במשתנה עזר - מוצר

        //        Order order = (this[i] as Order);
        //        if
        //        (

        //        //סינון לפי שם המוצר

        //       (id == 0 || order.ID == id)

        //        //סינון לפי החברה
        //        && (client == null || client.ID == -1 || order.Client.ID == client.ID)
        //        //סינון לפי קטגוריה
        //        && (IsDate(order, from, to))
        //        )

        //            //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

        //            orderArr.Add(order);
        //    }
        //    return orderArr;
        //}

        public bool IsDate(Order order, DateTime from, DateTime to)
        {
            if (from == DateTime.MinValue && to != DateTime.MinValue)
                return IsAfter(to, order.Date);

            else if (to == DateTime.MinValue && from != DateTime.MinValue)
                return IsAfter(order.Date, from);

            else if (to == DateTime.MinValue && from == DateTime.MinValue)
                return true;

            else
            {
                if (IsAfter(order.Date, from) && IsAfter(to, order.Date))
                    return true;
                else
                    return false;
            }
        }

        public bool IsAfter(DateTime from, DateTime to)
        {

            if (from.Year > to.Year)
                return true;
            else if (from.Year < to.Year)
                return false;

            if (from.Month > to.Month)
                return true;
            else if (from.Month < to.Month)
                return false;

            if (from.Day >= to.Day)
                return true;
            return false;
        }

        private bool CheckForm()
        {
            bool flag = true;

            if (textBox_Comment.Text.Length < 1)
            {
                flag = false;
                textBox_Comment.BackColor = Color.Red;
            }
            else
                textBox_Comment.BackColor = Color.White;

            if (!dateTimePicker.Checked)
            {
                flag = false;
                dateTimePicker.CalendarForeColor = Color.Red;
            }
            else
                dateTimePicker.CalendarForeColor = Color.White;

            if (label_ChooseClient.Text == "None Chosen")
            {
                flag = false;
                label_ChooseClient.BackColor = Color.Red;
            }
            else
                label_ChooseClient.BackColor = Color.White;
            if (listBox_InOrderProducts.Items.Count == 0)
            {
                flag = false;
                listBox_InOrderProducts.BackColor = Color.Red;
            }
            else
                listBox_InOrderProducts.BackColor = Color.White;
            if (listBox_InOrderAccessories.Items.Count == 0)
            {
                flag = false;
                listBox_InOrderAccessories.BackColor = Color.Red;
            }
            else
                listBox_InOrderAccessories.BackColor = Color.White;

            return flag;
        }
        private Order FormToOrder()
        {
            Order order = new Order
            {
                ID = int.Parse(label_Id.Text),
                Date = dateTimePicker.Value,
                Client = ClientListBox.SelectedItem as Client,
                Comment = textBox_Comment.Text
            };



            return order;

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
                Order order = FormToOrder();

                OrderProductArr orderProductArr_New;
                OrderAccessoriesArr orderAccessoriesArr_New;

                if (order.ID == 0)
                {
                    if (order.Insert())
                    {
                        OrderArr orderArr = new OrderArr();
                        orderArr.Fill();
                        order = orderArr.GetOrderWithMaxId();

                        orderProductArr_New = FormToOrderProductArr(order);
                        orderAccessoriesArr_New = FormToOrderAccessoryArr(order);

                        if (orderProductArr_New.Insert() && orderAccessoriesArr_New.Insert())
                            MessageBox.Show("Form filled successfully", "Yay!", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Error adding", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        OrderToForm(null);
                        //מעדכנים את מלאי הפריטים שהוזמנו

                        (listBox_InOrderProducts.DataSource as ProductArr).UpdateCount();
                        (listBox_InOrderAccessories.DataSource as AccessoriesArr).UpdateCount();
                    }
                    else
                        MessageBox.Show("Error adding", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                else
                {
                    if (order.Update())
                    {
                        //מוחקים את הפריטים הקודמים של ההזמנה
                        //אוסף כלל הזוגות - הזמנה-פריט

                        OrderProductArr orderProductArr_Old = new OrderProductArr();
                        orderProductArr_Old.Fill();
                        OrderAccessoriesArr orderAccessoriesArr_Old = new OrderAccessoriesArr();
                        orderAccessoriesArr_Old.Fill();

                        //סינון לפי ההזמנה הנוכחית

                        orderProductArr_Old = orderProductArr_Old.Filter(order);
                        orderAccessoriesArr_Old = orderAccessoriesArr_Old.Filter(order);

                        //מחיקת כל הפריטים באוסף ההזמנה-פריט של ההזמנה הנוכחית

                        orderProductArr_Old.Delete();
                        orderAccessoriesArr_Old.Delete();

                        //מוסיפים את הפריטים לפי העדכני להזמנה

                        orderProductArr_New = FormToOrderProductArr(order);
                        orderProductArr_New.Insert();
                        orderAccessoriesArr_New = FormToOrderAccessoryArr(order);
                        orderAccessoriesArr_New.Insert();
                        //מעדכנים את מלאי הפריטים, אלו שהוזמנו ואלו שבפוטנציאל

                        (listBox_InOrderProducts.DataSource as ProductArr).UpdateCount();
                        (listBox_PotentialProducts.DataSource as ProductArr).UpdateCount();
                        (listBox_InOrderAccessories.DataSource as AccessoriesArr).UpdateCount();
                        (listBox_PotentialAccessories.DataSource as AccessoriesArr).UpdateCount();
                        MessageBox.Show("Updated successfully", "Yay!", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Error");
                }

                OrderArrToForm();
            }
        }

        private void OrderArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס


            OrderArr orderArr = new OrderArr();
            Order orderDefault = new Order();
            orderDefault.ID = -1;
            orderDefault.Client = new Client();
            orderDefault.Client.LastName = "Choose";
            orderDefault.Client.FirstName = "an Order";



            orderArr.Fill();
            listBox_Orders.DataSource = orderArr;


        }

        private void OrderToForm(Order order)
        {
            if (order != null)
            {
                //ממירה את המידע בטנ"מ לקוח לטופס
                label_Id.Text = order.ID.ToString();
                textBox_Comment.Text = order.Comment;
                dateTimePicker.Value = order.Date;
                label_ChooseClient.Text = order.Client.FirstName + " " + order.Client.LastName;
                ClientListBox.SelectedValue = order.Client.ID;

            }

            else
            {
                label_Id.Text = "0";
                textBox_Comment.Text = "";
                dateTimePicker.Value = DateTime.Now;
                label_ChooseClient.Text = "None Chosen";
                FirstNameLabel.Text = "None Chosen";
                LastNameLabel.Text = "None Chosen";
                PhoneLabel.Text = "None Chosen";
                ProductArrToForm(listBox_PotentialProducts);
                AccessoryArrToForm(listBox_PotentialAccessories);
                OrderArrToForm();
                ClientArrToForm();
                listBox_InOrderProducts.DataSource = null;
                listBox_InOrderProductsCount.Items.Clear();
                listBox_InOrderAccessories.DataSource = null;
                listBox_InOrderAccessoriesCount.Items.Clear();
                ClientFilterTextBox.Text = "";
                IDFilterTextBox.Text = "";
                PhoneFilterTextBox.Text = "";
                LastNameFilterTextBox.Text = "";
            }

        }
        private void listBox_Order_DoubleClick(object sender, EventArgs e)
        {
            Order order = listBox_Orders.SelectedItem as Order;
            OrderToForm(order);
            FirstNameLabel.Text = order.Client.FirstName;
            LastNameLabel.Text = order.Client.LastName;
            PhoneLabel.Text = "0" + order.Client.PhoneNumber.ToString();
            ClientListBox.SelectedValue = order.Client.ID;


            OrderProductArr orderProductArr = new OrderProductArr();
            orderProductArr.Fill();
            OrderAccessoriesArr orderAccessoriesArr = new OrderAccessoriesArr();
            orderAccessoriesArr.Fill();

            //סינון לפי הזמנה נוכחית

            orderProductArr = orderProductArr.Filter(order);
            orderAccessoriesArr = orderAccessoriesArr.Filter(order);

            //רק אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה
            AccessoriesArr accessoriesArrInOrder = orderAccessoriesArr.GetAccessoriesArr();
            ProductArr productArrInOrder = orderProductArr.GetProductArr();
            ProductArrToForm(listBox_InOrderProducts, productArrInOrder);
            ProductArrCountToForm(orderProductArr);
            AccessoryArrToForm(listBox_InOrderAccessories, accessoriesArrInOrder);
            AccessoriesArrCountToForm(orderAccessoriesArr);

            //תיבת רשימה - פריטים פוטנציאלים
            //כל הפריטים - פחות אלו שכבר נבחרו

            ProductArr productArrNotInOrder = new ProductArr();
            productArrNotInOrder.Fill();
            AccessoriesArr accessoriesArrNotInOrder = new AccessoriesArr();
            accessoriesArrNotInOrder.Fill();

            //הורדת הפריטים שכבר קיימים בהזמנה

            productArrNotInOrder.Remove(productArrInOrder);
            accessoriesArrNotInOrder.Remove(accessoriesArrInOrder);
            ProductArrToForm(listBox_PotentialProducts, productArrNotInOrder);
            AccessoryArrToForm(listBox_PotentialAccessories, accessoriesArrNotInOrder);




        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OrderToForm(null);
        }

        private void Order_Filter(object sender, KeyEventArgs e)
        {
            int id = 0;
            DateTime startDate = DateTime.MinValue;
            DateTime endDate = DateTime.MinValue;

            //אם המשתמש רשם ערך בשדה המזהה

            if (IDFilterTextBox.Text != "")
                id = int.Parse(IDFilterTextBox.Text);
            if (dateTimePicker_StartDate.Checked)
                startDate = dateTimePicker_StartDate.Value.Date;
            if (EndDatePickerFilter.Checked)
                endDate = EndDatePickerFilter.Value.Date;

            //מייצרים אוסף של כלל הלקוחות

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();


            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            orderArr = orderArr.Filter(id, startDate, endDate, ClientFilterTextBox.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Orders.DataSource = orderArr;
        }
        private void DatePickerFilter_ValueChanged(object sender, EventArgs e)
        {
            int id = 0;
            DateTime startDate = DateTime.MinValue;
            DateTime endDate = DateTime.MinValue;


            if (IDFilterTextBox.Text != "")
                id = int.Parse(IDFilterTextBox.Text);
            if (dateTimePicker_StartDate.Checked)
                startDate = dateTimePicker_StartDate.Value.Date;
            if (EndDatePickerFilter.Checked)
                endDate = EndDatePickerFilter.Value.Date;


            OrderArr orderArr = new OrderArr();
            orderArr.Fill();



            orderArr = orderArr.Filter(id, startDate, endDate, ClientFilterTextBox.Text);

            listBox_Orders.DataSource = orderArr;
        }
        private void ClientArrToForm()
        {
            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            ClientListBox.DataSource = clientArr;
            ClientListBox.ValueMember = "ID";
            ClientListBox.DisplayMember = "";
        }

        private void Client_Filter(object sender, KeyEventArgs e)
        {


            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            string phonenumber;
            if (PhoneFilterTextBox.Text != "")
            {
                if (PhoneFilterTextBox.Text[0] == '0')
                    phonenumber = PhoneFilterTextBox.Text.Substring(1);
                else
                    phonenumber = PhoneFilterTextBox.Text;
            }
            else
                phonenumber = PhoneFilterTextBox.Text;

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(0, LastNameFilterTextBox.Text,
            phonenumber);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            ClientListBox.DataSource = clientArr;
        }

        private void Form_Order_Load(object sender, EventArgs e)
        {

        }

        private void ClientListBox_DoubleClick(object sender, EventArgs e)
        {
            Client client = ClientListBox.SelectedItem as Client;
            FirstNameLabel.Text = client.FirstName;
            LastNameLabel.Text = client.LastName;
            PhoneLabel.Text = "0" + client.PhoneNumber.ToString();
            label_ChooseClient.Text = client.FirstName + " " + client.LastName;
        }

        private void ProductArrToForm(ListBox listBox, ProductArr productArr = null)
        {

            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (productArr == null)
            {
                productArr = new ProductArr();
                productArr.Fill();
            }
            listBox.DataSource = productArr;

            
        }



        private OrderProductArr FormToOrderProductArr(Order curOrder)
        {

            // יצירת אוסף המוצרים להזמנה מהטופס
            // מייצרים זוגות של הזמנה-מוצר , ההזמנה - תמיד אותה הזמנה )הרי מדובר על הזמנה אחת(, המוצר - מגיע מרשימת המוצרים שנבחרו
            OrderProductArr orderProductArr = new OrderProductArr();
            //יצירת אוסף הזוגות הזמנה -מוצר
            OrderProduct orderProduct;

            //סורקים את כל הערכים בתיבת הרשימה של המוצרים שנבחרו להזמנה
            for (int i = 0; i < listBox_InOrderProducts.Items.Count; i++)
            {
                orderProduct = new OrderProduct();

                //ההזמנה הנוכחית היא ההזמנה לכל הזוגות באוסף

                orderProduct.Order = curOrder;

                //מוצר נוכחי לזוג הזמנה-מוצר

                orderProduct.Product = listBox_InOrderProducts.Items[i] as Product;
                //כמות מוצר נוכחי לזוג הזמנה-מוצר
                orderProduct.Count = (int)listBox_InOrderProductsCount.Items[i];

                //הוספת הזוג הזמנה -מוצר לאוסף

                orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }

        private void listBox_PotentialProducts_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_PotentialProducts, listBox_InOrderProducts, true);
        }
        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To, bool isToOrder)
        {
            ProductArr productArr = null;

            //מוצאים את הפריט הנבחר

            Product selectedItem = listBox_From.SelectedItem as Product;

            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים
            if (isToOrder)

            //ההעברה היא מהרשימה של הפריטים הפוטנציאלים

            {
                (selectedItem as Product).Count--;
                listBox_InOrderProductsCount.Items.Add(1);
            }
            else
            {
                (selectedItem as Product).Count += (int)listBox_InOrderProductsCount.SelectedItem;
                listBox_InOrderProductsCount.Items.RemoveAt(listBox_InOrderProductsCount.SelectedIndex);
            }

            if (listBox_To.DataSource != null)
                productArr = listBox_To.DataSource as ProductArr;
            else
            {
                productArr = new ProductArr();
            }
                
            productArr.Add(selectedItem);
            ProductArrToForm(listBox_To, productArr);

            ///הסרת הפריט הנבחר מרשימת הפריטים הנבחרים

            productArr = listBox_From.DataSource as ProductArr;
            productArr.Remove(selectedItem);
            ProductArrToForm(listBox_From, productArr);
            //בסוף הפעולה
            //אם זאת הוספה לתיבת המוצרים בהזמנה - סימון שתי השורה האחרונה בה וגם בתיבת הרשימה של הכמויות

            if (isToOrder)
            {
                int k = listBox_To.Items.Count - 1;
                listBox_To.SelectedIndex = k;
                listBox_InOrderProductsCount.SelectedIndex = k;
            }
        }




        private void button_Plus_Click(object sender, EventArgs e)
        {
            //הגדלת הכמות של המוצר בהזמנה באחד
            //אם לא מסומנת השורה של הכמויות

            if (listBox_InOrderProductsCount.SelectedIndex >= 0)

                //בדיקה האם יש במלאי לפחות 1

                if ((listBox_InOrderProducts.SelectedItem as Product).Count > 0)

                //אם כן, הוספה לכמות של פריט-הזמנה והורדה מהמלאי

                {

                    //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה

                    int k = listBox_InOrderProductsCount.SelectedIndex;
                    listBox_InOrderProductsCount.Items[k] =
                    (int)listBox_InOrderProductsCount.Items[k] + 1;

                    //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                    ProductArr productArr = listBox_InOrderProducts.DataSource as ProductArr;
                    Product product = listBox_InOrderProducts.SelectedItem as Product;
                    product.Count--;
                    productArr.UpdateProduct(product);
                    ProductArrToForm(listBox_InOrderProducts, productArr);
                }

                //אם לא הודעה מתאימה

                else
                    MessageBox.Show("error adding");

        }

        private void listBox_InOrderProducts_Click(object sender, EventArgs e)
        {
            listBox_InOrderProductsCount.SelectedIndex = listBox_InOrderProducts.SelectedIndex;
        }
        private void listBox_InOrderProductsCount_Click(object sender, EventArgs e)
        {
            listBox_InOrderProducts.SelectedIndex = listBox_InOrderProductsCount.SelectedIndex;
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            //הקטנת הכמות של המוצר בהזמנה באחד
            //בדיקה שמסומנת השורה של הכמויות

            if (listBox_InOrderProductsCount.SelectedIndex >= 0)

            // הוספה לכמות של פריט-הזמנה

            {

                //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה

                int k = listBox_InOrderProductsCount.SelectedIndex;
                listBox_InOrderProductsCount.Items[k] = (int)listBox_InOrderProductsCount.Items[k] - 1;
                //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                ProductArr productArr = listBox_InOrderProducts.DataSource as ProductArr;
                Product product = listBox_InOrderProducts.SelectedItem as Product;
                product.Count++;
                productArr.UpdateProduct(product);
                ProductArrToForm(listBox_InOrderProducts, productArr);
            }
        }
        private void listBox_InOrderProducts_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_InOrderProducts ,listBox_PotentialProducts, false);
        }
        private void AccessoryArrToForm(ListBox listBox, AccessoriesArr AccessoryArr = null)
        {

            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (AccessoryArr == null)
            {
                AccessoryArr = new AccessoriesArr();
                AccessoryArr.Fill();
            }
            listBox.DataSource = AccessoryArr;

            AccessoriesArr comboBoxArr = new AccessoriesArr();
            Accessories AccessoryDefault = new Accessories();
            AccessoryDefault.Id = -1;
            AccessoryDefault.Name = "Choose a Accessory";
            comboBoxArr.Add(AccessoryDefault);
            comboBoxArr.Fill();
            comboBox_CompanyFilter.DataSource = comboBoxArr;
            comboBox_CompanyFilter.ValueMember = "Id";
            comboBox_CompanyFilter.DisplayMember = "Name";
        }

        private OrderAccessoriesArr FormToOrderAccessoryArr(Order curOrder)
        {

            // יצירת אוסף המוצרים להזמנה מהטופס
            // מייצרים זוגות של הזמנה-מוצר , ההזמנה - תמיד אותה הזמנה )הרי מדובר על הזמנה אחת(, המוצר - מגיע מרשימת המוצרים שנבחרו
            OrderAccessoriesArr orderAccessoryArr = new OrderAccessoriesArr();
            //יצירת אוסף הזוגות הזמנה -מוצר
            OrderAccessories orderAccessory;

            //סורקים את כל הערכים בתיבת הרשימה של המוצרים שנבחרו להזמנה
            for (int i = 0; i < listBox_InOrderAccessoriesCount.Items.Count; i++)
            {
                orderAccessory = new OrderAccessories();

                //ההזמנה הנוכחית היא ההזמנה לכל הזוגות באוסף

                orderAccessory.Order = curOrder;

                //מוצר נוכחי לזוג הזמנה-מוצר

                orderAccessory.Accessories = listBox_InOrderAccessoriesCount.Items[i] as Accessories;

                orderAccessory.Count = (int)listBox_InOrderAccessoriesCount.Items[i];
                //הוספת הזוג הזמנה -מוצר לאוסף

                orderAccessoryArr.Add(orderAccessory);
            }
            return orderAccessoryArr;
        }

        private void listBox_PotentialAccessories_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox1(listBox_PotentialAccessories, listBox_InOrderAccessories, true);
        }
        private void MoveSelectedItemBetweenListBox1(ListBox listBox_From, ListBox listBox_To, bool isToOrder)
        {
            AccessoriesArr accessoriesArr = null;

            //מוצאים את הפריט הנבחר

            Accessories selectedItem = listBox_From.SelectedItem as Accessories;

            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים
            if (isToOrder)

            //ההעברה היא מהרשימה של הפריטים הפוטנציאלים

            {
                (selectedItem as Accessories).Count--;
                listBox_InOrderAccessoriesCount.Items.Add(1);
            }
            else
            {
                (selectedItem as Accessories).Count += (int)listBox_InOrderAccessoriesCount.SelectedItem;
                listBox_InOrderAccessoriesCount.Items.RemoveAt(listBox_InOrderAccessoriesCount.SelectedIndex);
            }

            if (listBox_To.DataSource != null)
                accessoriesArr = listBox_To.DataSource as AccessoriesArr;
            else
            {
                accessoriesArr = new AccessoriesArr();
            }

            accessoriesArr.Add(selectedItem);
            AccessoryArrToForm(listBox_To, accessoriesArr);

            ///הסרת הפריט הנבחר מרשימת הפריטים הנבחרים

            accessoriesArr = listBox_From.DataSource as AccessoriesArr;
            accessoriesArr.Remove(selectedItem);
            AccessoryArrToForm(listBox_From, accessoriesArr);
            //בסוף הפעולה
            //אם זאת הוספה לתיבת המוצרים בהזמנה - סימון שתי השורה האחרונה בה וגם בתיבת הרשימה של הכמויות

            if (isToOrder)
            {
                int k = listBox_To.Items.Count - 1;
                listBox_To.SelectedIndex = k;
                listBox_InOrderAccessoriesCount.SelectedIndex = k;
            }
        }
        private void button_Plus1_Click(object sender, EventArgs e)
        {
            //הגדלת הכמות של המוצר בהזמנה באחד
            //אם לא מסומנת השורה של הכמויות

            if (listBox_InOrderAccessoriesCount.SelectedIndex >= 0)

                //בדיקה האם יש במלאי לפחות 1

                if ((listBox_InOrderAccessories.SelectedItem as Accessories).Count > 0)

                //אם כן, הוספה לכמות של פריט-הזמנה והורדה מהמלאי

                {

                    //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה

                    int k = listBox_InOrderAccessoriesCount.SelectedIndex;
                    listBox_InOrderAccessoriesCount.Items[k] =
                    (int)listBox_InOrderAccessoriesCount.Items[k] + 1;

                    //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                    AccessoriesArr AccessoriesArr = listBox_InOrderAccessories.DataSource as AccessoriesArr;
                    Accessories Accessory = listBox_InOrderAccessories.SelectedItem as Accessories;
                    Accessory.Count--;
                    AccessoriesArr.UpdateAccessories(Accessory);
                    AccessoryArrToForm(listBox_InOrderAccessories, AccessoriesArr);
                }

                //אם לא הודעה מתאימה

                else
                    MessageBox.Show("error adding");

        }

        private void listBox_InOrderAccessories_Click(object sender, EventArgs e)
        {
            listBox_InOrderAccessories.SelectedIndex = listBox_InOrderAccessoriesCount.SelectedIndex;
        }
        private void listBox_InOrderAccessoriesCount_Click(object sender, EventArgs e)
        {
            listBox_InOrderAccessoriesCount.SelectedIndex = listBox_InOrderAccessories.SelectedIndex;
        }

        private void button_Minus1_Click(object sender, EventArgs e)
        {
            //הגדלת הכמות של המוצר בהזמנה באחד
            //אם לא מסומנת השורה של הכמויות

            if (listBox_InOrderAccessoriesCount.SelectedIndex >= 0)

                //בדיקה האם יש במלאי לפחות 1

                if ((listBox_InOrderAccessories.SelectedItem as Accessories).Count > 0)

                //אם כן, הוספה לכמות של פריט-הזמנה והורדה מהמלאי

                {

                    //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה

                    int k = listBox_InOrderAccessoriesCount.SelectedIndex;
                    listBox_InOrderAccessoriesCount.Items[k] =
                    (int)listBox_InOrderAccessoriesCount.Items[k] - 1;

                    //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                    AccessoriesArr AccessoriesArr = listBox_InOrderAccessories.DataSource as AccessoriesArr;
                    Accessories Accessory = listBox_InOrderAccessories.SelectedItem as Accessories;
                    Accessory.Count++;
                    AccessoriesArr.UpdateAccessories(Accessory);
                    AccessoryArrToForm(listBox_InOrderAccessories, AccessoriesArr);
                }

                //אם לא הודעה מתאימה

                else
                    MessageBox.Show("error ");
        }
        private void listBox_InOrderAccessories_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox1(listBox_InOrderAccessoriesCount, listBox_PotentialAccessories, false);
        }

        private void ClientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ProductFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductArr productArr = new ProductArr();
            productArr.Fill();


            productArr = productArr.Filter(textBox_NameProoduct.Text,
            CompanyFilterComboBox.SelectedItem as Company, CategoryFilterComboBox.SelectedItem as Category);


            listBox_PotentialProducts.DataSource = productArr;
        }
        private void AccessoriesFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccessoriesArr accessoriesArr = new AccessoriesArr();
            accessoriesArr.Fill();


            accessoriesArr = accessoriesArr.Filter(textBox_AccessoriesName.Text,
            comboBox_CompanyFilter.SelectedItem as CompanyAccessories, comboBox_CategryFilter.SelectedItem as CategoryAccessories);


            listBox_PotentialAccessories.DataSource = accessoriesArr;
        }

        private void ProductArrCountToForm(OrderProductArr curOrderproductArr)
        {
            listBox_InOrderProductsCount.Items.Clear();
            for (int i = 0; i < curOrderproductArr.Count; i++)
            {
                listBox_InOrderProductsCount.Items.Add(
                (curOrderproductArr[i] as OrderProduct).Count);
            }

            //כדי לסמן את השורה הראשונה ישר בהתחלה )אם יש כזאת(

            if (listBox_InOrderProductsCount.Items.Count > 0)
                listBox_InOrderProductsCount.SelectedIndex = 0;
        }

        private void AccessoriesArrCountToForm(OrderAccessoriesArr curOrderAccessoriesArr)
        {
            listBox_InOrderAccessoriesCount.Items.Clear();
            for (int i = 0; i < curOrderAccessoriesArr.Count; i++)
            {
                listBox_InOrderAccessoriesCount.Items.Add(
                (curOrderAccessoriesArr[i] as OrderAccessories).Count);
            }

            //כדי לסמן את השורה הראשונה ישר בהתחלה )אם יש כזאת(

            if (listBox_InOrderAccessoriesCount.Items.Count > 0)
                listBox_InOrderAccessoriesCount.SelectedIndex = 0;
        }

        public void CompanyArrToForm()
        {


            CompanyArr companyArr = new CompanyArr();


            Company companyDefault = new Company();
            companyDefault.Id = -1;
            companyDefault.Name = "Select company";


            companyArr.Add(companyDefault);
            companyArr.Fill();

            CompanyFilterComboBox.DataSource = companyArr;
            CompanyFilterComboBox.ValueMember = "Id";
            CompanyFilterComboBox.DisplayMember = "Name";

        }
        public void CategoryArrToForm()
        {


            CategoryArr categoryArr = new CategoryArr();


            Category categoryDefault = new Category();
            categoryDefault.Id = -1;
            categoryDefault.Name = "Select category";


            categoryArr.Add(categoryDefault);
            categoryArr.Fill();


            CategoryFilterComboBox.DataSource = categoryArr;
            CategoryFilterComboBox.ValueMember = "Id";
            CategoryFilterComboBox.DisplayMember = "Name";

        }

        public void CompanyAccessoriesArrToForm()
        {


            CompanyAccessoriesArr companyAccessoriesArr = new CompanyAccessoriesArr();


            CompanyAccessories companyDefault = new CompanyAccessories();
            companyDefault.Id = -1;
            companyDefault.Name = "Select company";


            companyAccessoriesArr.Add(companyDefault);
            companyAccessoriesArr.Fill();

            comboBox_CompanyFilter.DataSource = companyAccessoriesArr;
            comboBox_CompanyFilter.ValueMember = "Id";
            comboBox_CompanyFilter.DisplayMember = "Name";

        }
        public void CategoryAccessoriesArrToForm()
        {


            CategoryAccessoriesArr categoryAccessoriesArr = new CategoryAccessoriesArr();


            CategoryAccessories categoryDefault = new CategoryAccessories();
            categoryDefault.Id = -1;
            categoryDefault.Name = "Select category";


            categoryAccessoriesArr.Add(categoryDefault);
            categoryAccessoriesArr.Fill();


            comboBox_CategryFilter.DataSource = categoryAccessoriesArr;
            comboBox_CategryFilter.ValueMember = "Id";
            comboBox_CategryFilter.DisplayMember = "Name";

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Order order = FormToOrder();
            OrderProductArr orderProductArr = FormToOrderProductArr(order);
            OrderAccessoriesArr orderAccessoriesArr = FormToOrderAccessoryArr(order);
            if (order.ID == 0)
                MessageBox.Show("You need to choose an order");
            else
            {

                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    for (int i = 0; i < listBox_InOrderProducts.Items.Count; i++)
                    {
                        listBox_InOrderProducts.SelectedIndex = i;
                        listBox_InOrderProductsCount.SelectedIndex = i;
                        Product selectedItem = listBox_InOrderProducts.SelectedItem as Product;
                        selectedItem.Count += (int)listBox_InOrderProductsCount.SelectedItem;
                        productArr.UpdateProduct(selectedItem);
                        productArr.UpdateCount();

                    }

                    AccessoriesArr accessoriesArr = new AccessoriesArr();
                    accessoriesArr.Fill();
                    for (int i = 0; i < listBox_InOrderAccessories.Items.Count; i++)
                    {
                        listBox_InOrderAccessories.SelectedIndex = i;
                        listBox_InOrderAccessoriesCount.SelectedIndex = i;
                        Accessories selectedItem = listBox_InOrderAccessories.SelectedItem as Accessories;
                        selectedItem.Count += (int)listBox_InOrderAccessoriesCount.SelectedItem;
                        accessoriesArr.UpdateAccessories(selectedItem);
                        accessoriesArr.UpdateCount();

                    }
                    if (order.Delete() && orderProductArr.Delete() && orderAccessoriesArr.Delete())
                    {
                        MessageBox.Show("Order deleted successfully!", "Yay!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    OrderToForm(null);
                    OrderArrToForm();
                }
            }
        }
    }
}
