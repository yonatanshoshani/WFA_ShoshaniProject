using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using WFA_ShoshaniProject.DAL;

namespace WFA_ShoshaniProject.BL
{
    public class OrderAccessoriesArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = OrderAccessories_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            OrderAccessories curOrderAccessories;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrderAccessories = new OrderAccessories(dataRow);
                this.Add(curOrderAccessories);
            }
        }

        public OrderAccessoriesArr Filter(Order order)
        {
            OrderAccessoriesArr orderAccessoriesArr = new OrderAccessoriesArr();
            OrderAccessories orderAccessories;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                orderAccessories = (this[i] as OrderAccessories);

                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                orderAccessories.Order.ID == order.ID
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    orderAccessoriesArr.Add(orderAccessories);
            }
            return orderAccessoriesArr;
        }

        public OrderAccessoriesArr Filter(Accessories Accessories)
        {
            OrderAccessoriesArr orderAccessoriesArr = new OrderAccessoriesArr();
            OrderAccessories orderAccessories;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                orderAccessories = (this[i] as OrderAccessories);

                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                orderAccessories.Accessories.Id == Accessories.Id   
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    orderAccessoriesArr.Add(orderAccessories);
            }
            return orderAccessoriesArr;
        }

        public bool DoesExist(Client curClient)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).Client.ID == curClient.ID)
                    return true;

            return false;
        }

        public bool Insert()
        {

            // מוסיפה את אוסף המוצרים להזמנה למסד הנתונים

            OrderAccessories orderAccessories;
            for (int i = 0; i < this.Count; i++)
            {
                orderAccessories = (this[i] as OrderAccessories);
                if (!orderAccessories.Insert())
                    return false;
            }
            return true;
        }

        public AccessoriesArr GetAccessoriesArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            AccessoriesArr AccessoriesArr = new AccessoriesArr();
            for (int i = 0; i < this.Count; i++)
                AccessoriesArr.Add((this[i] as OrderAccessories).Accessories);
            return AccessoriesArr;
        }

        public bool Delete()
        {

            //מוחקת את אוסף המוצרים להזמנה ממסד הנתונים

            for (int i = 0; i < this.Count; i++)
                (this[i] as OrderAccessories).Delete();
            return true;
        }
        public void UpdateAccessories(Accessories Accessories)
        {

            //מעדכנת את הכמות של הפריט באוסף הנוכחי

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Accessories).Id == Accessories.Id)
                {
                    this[i] = Accessories;
                    return;
                }
        }
    }
}