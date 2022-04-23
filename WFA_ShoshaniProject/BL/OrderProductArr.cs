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
    public class OrderProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = OrderProduct_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            OrderProduct curOrderProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrderProduct = new OrderProduct(dataRow);
                this.Add(curOrderProduct);
            }
        }

        public OrderProductArr Filter(Order order)
        {
            OrderProductArr orderProductArr = new OrderProductArr();
            OrderProduct orderProduct;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                orderProduct = (this[i] as OrderProduct);

                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                orderProduct.Order.ID == order.ID
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }

        public OrderProductArr Filter(Product product)
        {
            OrderProductArr orderProductArr = new OrderProductArr();
            OrderProduct orderProduct;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                orderProduct = (this[i] as OrderProduct);

                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                orderProduct.Product.Id == product.Id   
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
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

            OrderProduct orderProduct;
            for (int i = 0; i < this.Count; i++)
            {
                orderProduct = (this[i] as OrderProduct);
                if (!orderProduct.Insert())
                    return false;
            }
            return true;
        }

        public ProductArr GetProductArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            ProductArr productArr = new ProductArr();
            for (int i = 0; i < this.Count; i++)
                productArr.Add((this[i] as OrderProduct).Product);
            return productArr;
        }

        public bool Delete()
        {

            //מוחקת את אוסף המוצרים להזמנה ממסד הנתונים

            for (int i = 0; i < this.Count; i++)
                (this[i] as OrderProduct).Delete();
            return true;
        }
        public void UpdateProduct(Product product)
        {

            //מעדכנת את הכמות של הפריט באוסף הנוכחי

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Id == product.Id)
                {
                    this[i] = product;
                    return;
                }
        }
        
    }
}