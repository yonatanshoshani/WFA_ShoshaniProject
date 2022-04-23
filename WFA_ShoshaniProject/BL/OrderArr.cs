using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using WFA_ShoshaniProject.DAL;
using System.Globalization;
namespace WFA_ShoshaniProject.BL
{
    public class OrderArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Order_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Order curOrder;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrder = new Order(dataRow);
                this.Add(curOrder);
            }
        }

        public OrderArr Filter(int id, DateTime startDate, DateTime endDate, String client)
        {
            OrderArr orderArr = new OrderArr();
            Order order;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                order = (this[i] as Order);
                string name = (order.Client.FirstName + " " + order.Client.LastName).ToLower();
                string inversename = (order.Client.LastName + " " + order.Client.FirstName).ToLower();
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || order.ID == id)
                && (startDate == DateTime.MinValue || order.Date >= startDate)
                && (endDate == DateTime.MinValue || order.Date <= endDate)
                && (client == "" || name.Contains(client.ToLower()) || inversename.Contains(client.ToLower()))
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    orderArr.Add(order);
            }
            return orderArr;
        }

        public bool DoesExist(Client curClient)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).Client.ID == curClient.ID)
                    return true;

            return false;
        }

        public Order GetOrderWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Order maxOrder = new Order();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).ID > maxOrder.ID)
                    maxOrder = this[i] as Order;

            return maxOrder;
        }
        public SortedDictionary<string, int> GetSortedDictionary(City city = null)
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            if (city == null)
            {
                ClientArr clientArr = new ClientArr();
                clientArr.Fill();
                // מחזירה משתנה מסוג מילון ממוין עם ערכים רלוונטיים לדוח
                CityArr clientsCityArr = clientArr.GetCityArr();
                foreach (City curCity in clientsCityArr)
                    dictionary.Add(curCity.Name, this.Filter(curCity).Count);
            }
            
            else
            {
                dictionary.Add(city.Name, this.Filter(city).Count);
            }
            return dictionary;

        }

        public OrderArr Filter(City city)

        {
            OrderArr orderArr = new OrderArr();
            Order o;
            for (int i = 0; i < this.Count; i++)
            {
                o = (this[i] as Order);
                if(o.Client.city.Id== city.Id)
                {
                    orderArr.Add(o);
                }
            }
            return orderArr;
        }

        public OrderArr Filter(int year, int month)
        {

            //מחזירה את אוסף ההזמנות מאותה שנה ואותו חודש

            OrderArr returnArr = new OrderArr();
            foreach (Order item in this)
                if (item.Date.Year == year && item.Date.Month == month)
                    returnArr.Add(item);
            return returnArr;
        }
        public Dictionary<string, int> GetOrderDictionary(int year)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות ההזמנות לאותו חודש
            OrderArr curOrderArr;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 1; i <= 12; i++)
            {
                curOrderArr = this.Filter(year, i);
                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                if (curOrderArr.Count > 0)
                {
                    dictionary.Add(monthName, curOrderArr.Count);
                }
            }

            return dictionary;
        }
    }
}
