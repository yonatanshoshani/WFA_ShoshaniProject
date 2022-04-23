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
//using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;



namespace WFA_ShoshaniProject.UI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            FillListViewCities();
            ProductArrToForm(comboBox_Product);
            FillListView_HighestSaleProduct();
            FillListView_Products();
            FillListView_Order();
            FillListView_Accessories();
            CompanyArrToForm(comboBox_Company);
            CategoryArrToForm(comboBox_Category);
            CityArrToForm(comboBox_City);
            orderFilterYearComboBox.SelectedIndex = 0;
            CityDataToChart();
            OrderDataToChart(int.Parse(orderFilterYearComboBox.SelectedItem.ToString()));
            CompanyAccessoriesArrToForm(comboBox_CompanyAccessories);
            CategoryAccessoriesArrToForm(comboBox_CategoryAccessories);
        }
        Bitmap m_bitmap;
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;

        ///////////////////////////////////////////////////////////////////////////////////////////////////
        private void FillListView_Products(ProductArr productArr = null)
        {
            listView_Products.Items.Clear();
            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים
            if (productArr == null)
            {
                ProductArr productArr1 = new ProductArr();
                productArr1.Fill();
                productArr = productArr1;
            }
            Product p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < productArr.Count; i++)
            {
                p = productArr[i] as Product;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.Name,

                p.Company.Name, p.Category.Name, p.Count.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Products.Items.Add(listViewItem);

            }
        }
        private void listView_Products_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Products.ListViewItemSorter = sorter;
            sorter = listView_Products.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = e.Column;

            // אם לחצו שוב על אותה עמודה - המיון יהיה בסדר הפוך לקודם

            if (m_LastColumnSortBy == e.Column)
                if (m_LastSortOrder == SortOrder.Ascending)
                    sorter.SortOrder = SortOrder.Descending;
                else
                    sorter.SortOrder = SortOrder.Ascending;

            // אחרת - זוהי עמודה חדשה - המיון יהיה בסדר עולה

            else
                sorter.SortOrder = SortOrder.Ascending;
            listView_Products.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }
        private void Product_Filter(object sender, KeyEventArgs e)
        {

            //מייצרים אוסף של כלל הלקוחות
            

            ProductArr ProductArr = new ProductArr();
            ProductArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            ProductArr = ProductArr.Filter(textBox_NameFilter.Text,
            comboBox_Company.SelectedItem as Company, comboBox_Category.SelectedItem as Category);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            FillListView_Products(ProductArr);
        }
        public void CompanyArrToForm(ComboBox comboBox, Company curCompany = null)
        {
            CompanyArr companyArr = new CompanyArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Company companyDefault = new Company();
            companyDefault.Id = -1;
            companyDefault.Name = "All companies";
            companyArr.Add(companyDefault);
            companyArr.Fill();
            comboBox.DataSource = companyArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCompany != null)
                comboBox.SelectedValue = curCompany.Id;
        }
        public void CategoryArrToForm(ComboBox comboBox, Category curCategory = null)
        {
            CategoryArr categoryArr = new CategoryArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Category categoryDefault = new Category();
            categoryDefault.Id = -1;
            categoryDefault.Name = "Select Category";
            categoryArr.Add(categoryDefault);
            categoryArr.Fill();
            comboBox.DataSource = categoryArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCategory != null)
                comboBox.SelectedValue = curCategory.Id;
        }
        private void SetProductsByFilter()
        {

            //מייצרים אוסף של כלל המוצרים

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(textBox_NameFilter.Text,
            comboBox_Company.SelectedItem as Company,
            comboBox_Category.SelectedItem as Category);

            //מציבים בתיבת הרשימה את אוסף המוצרים

            FillListView_Products(productArr);
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, 100, 100);
        }
        private void CaptureScreen(ListView listView)
        {

            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            int addAboveListView = -100;
            int moveLeft = -50;
            Graphics graphics = listView.CreateGraphics();
            Size curSize = listView.Size;
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(listView.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y - addAboveListView,
            moveLeft, 0, curSize);
        }

        private void CaptureScreen(Chart chart)
        {

            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            int addAboveListView = -35;
            int moveLeft = -10;
            Graphics graphics = chart.CreateGraphics();
            Size curSize = chart.Size;
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(chart.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y - addAboveListView,
            moveLeft, 0, curSize);
        }
        private void button_Print_Click(object sender, EventArgs e)
        {
            CaptureScreen(listView_Products);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Width = 600; printPreviewDialog1.Height = 800;
            printPreviewDialog1.ShowDialog();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void FillListView_Order(OrderArr orderArr = null)
        {
            listView_Orders.Items.Clear();
            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים
            if (orderArr == null)
            {
                OrderArr orderArr1 = new OrderArr();
                orderArr1.Fill();
                orderArr = orderArr1;
            }
            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים
            OrderProductArr orderProductArr = new OrderProductArr();
            orderProductArr.Fill();

            Order o;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < orderArr.Count; i++)
            {
                int Totalproducts = 0;
                o = orderArr[i] as Order;
                OrderProductArr curOrderProductArr = orderProductArr.Filter(o);
                for (int j = 0; j < curOrderProductArr.Count; j++)
                {
                    Totalproducts += (curOrderProductArr[j] as OrderProduct).Count;
                  
                }

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] {o.Client.FirstName+o.Client.LastName,

                o.Comment, o.Date.ToString("yyyy-MM-dd"), Totalproducts.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Orders.Items.Add(listViewItem);
            }
        }
        private void listView_Orders_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Orders.ListViewItemSorter = sorter;
            sorter = listView_Orders.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = e.Column;

            // אם לחצו שוב על אותה עמודה - המיון יהיה בסדר הפוך לקודם

            if (m_LastColumnSortBy == e.Column)
                if (m_LastSortOrder == SortOrder.Ascending)
                    sorter.SortOrder = SortOrder.Descending;
                else
                    sorter.SortOrder = SortOrder.Ascending;

            // אחרת - זוהי עמודה חדשה - המיון יהיה בסדר עולה

            else
                sorter.SortOrder = SortOrder.Ascending;
            listView_Orders.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void FillListView_Accessories(AccessoriesArr accessoriesArr= null)
        {

            listView_Accessories.Items.Clear();
            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים
            if (accessoriesArr == null)
            {
                AccessoriesArr accessoriesArr1 = new AccessoriesArr();
                accessoriesArr1.Fill();
                accessoriesArr = accessoriesArr1;
            }
            Accessories p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < accessoriesArr.Count; i++)
            {
                p = accessoriesArr[i] as Accessories;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.Name,

                p.Company.Name, p.Category.Name, p.Count.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Accessories.Items.Add(listViewItem);

            }
        }
        private void listView_Accessoriess_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Accessories.ListViewItemSorter = sorter;
            sorter = listView_Accessories.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = e.Column;

            // אם לחצו שוב על אותה עמודה - המיון יהיה בסדר הפוך לקודם

            if (m_LastColumnSortBy == e.Column)
                if (m_LastSortOrder == SortOrder.Ascending)
                    sorter.SortOrder = SortOrder.Descending;
                else
                    sorter.SortOrder = SortOrder.Ascending;

            // אחרת - זוהי עמודה חדשה - המיון יהיה בסדר עולה

            else
                sorter.SortOrder = SortOrder.Ascending;
            listView_Accessories.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }
        public void CompanyAccessoriesArrToForm(ComboBox comboBox, CompanyAccessories curCompanyAccessories = null)
        {
            CompanyAccessoriesArr CompanyAccessoriesArr = new CompanyAccessoriesArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            CompanyAccessories CompanyAccessoriesDefault = new CompanyAccessories();
            CompanyAccessoriesDefault.Id = -1;
            CompanyAccessoriesDefault.Name = "All companies";
            CompanyAccessoriesArr.Add(CompanyAccessoriesDefault);
            CompanyAccessoriesArr.Fill();
            comboBox.DataSource = CompanyAccessoriesArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCompanyAccessories != null)
                comboBox.SelectedValue = curCompanyAccessories.Id;
        }
        public void CategoryAccessoriesArrToForm(ComboBox comboBox, CategoryAccessories curCategoryAccessories = null)
        {
            CategoryAccessoriesArr CategoryAccessoriesArr = new CategoryAccessoriesArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            CategoryAccessories CategoryAccessoriesDefault = new CategoryAccessories();
            CategoryAccessoriesDefault.Id = -1;
            CategoryAccessoriesDefault.Name = "Select CategoryAccessories";
            CategoryAccessoriesArr.Add(CategoryAccessoriesDefault);
            CategoryAccessoriesArr.Fill();
            comboBox.DataSource = CategoryAccessoriesArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCategoryAccessories != null)
                comboBox.SelectedValue = curCategoryAccessories.Id;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void FillListViewCities()
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            Dictionary<string, int> dictionary = clientArr.GetDictionary();

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            ListViewItem listViewItem;
            foreach (KeyValuePair<string, int> item in dictionary.OrderByDescending(key => key.Value))
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                listView_Cities.Items.Add(listViewItem);
            }
        }
        public void CityArrToForm(ComboBox comboBox, City curCity = null)
        {
            CityArr cityArr = new CityArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            City CityDefault = new City();
            CityDefault.Id = -1;
            CityDefault.Name = "All cities";
            cityArr.Add(CityDefault);
            cityArr.Fill();
            comboBox.DataSource = cityArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCity != null)
                comboBox.SelectedValue = curCity.Id;
        }
        private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            Dictionary<string, int> dictionary;

            // בדיקה אם זה לא כל הערים
            if ((comboBox_City.SelectedItem as City).Id != -1)
                dictionary = clientArr.GetDictionary((comboBox_City.SelectedItem as City));
            else
                dictionary = clientArr.GetDictionary(); // לא עבד, מציג את כל הערים

            listView_Cities.Items.Clear();

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            ListViewItem listViewItem;
            foreach (KeyValuePair<string, int> item in dictionary.OrderByDescending(key => key.Value))
            {

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { item.Key, item.Value.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה

                listView_Cities.Items.Add(listViewItem);
            }

            
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        private void FillListView_HighestSaleProduct(ProductArr productArr = null)
        {
            if (productArr == null)
            {
                productArr = new ProductArr();
                productArr.Fill();
            }
                listView_HighestSaleProduct.Items.Clear();

                //מוסיף נתונים לפקד תיבת התצוגה
                //יצירת מקור הנתונים

;
                OrderProductArr orderProductArr = new OrderProductArr();
                orderProductArr.Fill();

                Product p;
                ListViewItem listViewItem;

                //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

                for (int i = 0; i < productArr.Count; i++)
                {
                    int Totalsales = 0;
                    p = productArr[i] as Product;
                    OrderProductArr curOrderProductArr = orderProductArr.Filter(p);
                    for (int j = 0; j < curOrderProductArr.Count; j++)
                    {
                        Totalsales += (curOrderProductArr[j] as OrderProduct).Count;

                    }

                    //יצירת פריט-תיבת-תצוגה
                    listViewItem = new ListViewItem(new[] {p.Name,

                    Totalsales.ToString() });
                    //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                    listView_HighestSaleProduct.Items.Add(listViewItem);
                }
        }
        private void listView_HighesSaleProduct_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_HighestSaleProduct.ListViewItemSorter = sorter;
            sorter = listView_HighestSaleProduct.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = e.Column;

            // אם לחצו שוב על אותה עמודה - המיון יהיה בסדר הפוך לקודם

            if (m_LastColumnSortBy == e.Column)
                if (m_LastSortOrder == SortOrder.Ascending)
                    sorter.SortOrder = SortOrder.Descending;
                else
                    sorter.SortOrder = SortOrder.Ascending;

            // אחרת - זוהי עמודה חדשה - המיון יהיה בסדר עולה

            else
                sorter.SortOrder = SortOrder.Ascending;
            listView_HighestSaleProduct.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }
        public void ProductArrToForm(ComboBox comboBox, Product curProduct = null)
        {
            ProductArr ProductArr = new ProductArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Product ProductDefault = new Product();
            ProductDefault.Id = -1;
            ProductDefault.Name = "All Products";
            ProductArr.Add(ProductDefault);
            ProductArr.Fill();
            comboBox.DataSource = ProductArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curProduct != null)
                comboBox.SelectedValue = curProduct.Id;
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////
        public void CityDataToChart()
        {
            city_Chart.Palette = ChartColorPalette.SeaGreen;
            city_Chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            city_Chart.Titles.Clear();
            city_Chart.Titles.Add("Numbers Of Orders By City");





            OrderArr curOrderArr = new OrderArr();
            curOrderArr.Fill();
            SortedDictionary<string, int> orderDictionary = curOrderArr.GetSortedDictionary();

            Series orderSeries = new Series("Orders Distribution");
            orderSeries.ChartType = SeriesChartType.Column;
            orderSeries.Color = Color.Blue;


            orderSeries.Label = "#VALX [#VAL = #PERCENT{P0}]";
            orderSeries.Points.DataBindXY(orderDictionary.Keys, orderDictionary.Values);

            city_Chart.Series.Clear();
            city_Chart.Series.Add(orderSeries);
        }

        public void OrderDataToChart(int year)
        {
            
            chart_Orders.Palette = ChartColorPalette.Pastel;
            chart_Orders.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart_Orders.Titles.Clear();
            chart_Orders.Titles.Add("Number of orders by Month");

            OrderArr curOrderArr = new OrderArr();
            curOrderArr.Fill();
            Dictionary<string, int> dictionary = curOrderArr.GetOrderDictionary(year);

            Series series = new Series("Orders By Month");
            series.ChartType = SeriesChartType.Line;



            series.Label = "#VALX [#VAL]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);


            chart_Orders.Series.Clear();
            chart_Orders.Series.Add(series);
        }

        private void DatePickerFilter_ValueChanged(object sender, EventArgs e)
        {
            int id = 0;
            DateTime startDate = DateTime.MinValue;
            DateTime endDate = DateTime.MinValue;


     
            if (dateTimePicker1.Checked)
                startDate = dateTimePicker1.Value.Date;
            if (dateTimePicker2.Checked)
                endDate = dateTimePicker2.Value.Date;


            OrderArr orderArr = new OrderArr();
            orderArr.Fill();



            orderArr = orderArr.Filter(id, startDate, endDate, "");

            FillListView_Order(orderArr);
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        private void SetProductsByFilter1()
        {

            //מייצרים אוסף של כלל המוצרים

            AccessoriesArr accessoriesArr = new AccessoriesArr();
            accessoriesArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            accessoriesArr = accessoriesArr.Filter(textBox_AccessoriesName.Text,
            comboBox_CompanyAccessories.SelectedItem as CompanyAccessories,
            comboBox_CategoryAccessories.SelectedItem as CategoryAccessories);

            //מציבים בתיבת הרשימה את אוסף המוצרים

            FillListView_Accessories(accessoriesArr);
        }
        private void comboBoxFilter_TextChanged1(object sender, EventArgs e)
        {
            SetProductsByFilter1();
        }

        private void orderFilterYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderDataToChart(int.Parse(orderFilterYearComboBox.SelectedItem.ToString()));
        }

        private void comboBox_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
                //מייצרים אוסף של כלל הלקוחות

                ProductArr ProductArr = new ProductArr();
                ProductArr.Fill();

                Product product = comboBox_Product.SelectedItem as Product;
                //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש
                if (product.Id > 0)
                {
                    ProductArr = ProductArr.Filter(product.Name,
                     product.Company, product.Category);
                }
                //מציבים בתיבת הרשימה את אוסף הלקוחות

                FillListView_HighestSaleProduct(ProductArr);

        }
    }

}
