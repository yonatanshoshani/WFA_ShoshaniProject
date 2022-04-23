using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WFA_ShoshaniProject.DAL
{
    class OrderProduct_Dal
    {
        public static bool Insert(int order, int product, int count)
        {
            string str = "INSERT INTO Table_OrderProduct"
            + "("
            + "[Order],[Product],[Count]"
            + ")"
            + " VALUES "
            + "("
            + $"{order}, {product}, {count}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_OrderProduct"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_OrderProduct", "[Order],[Product]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            Order_Dal.FillDataSet(dataSet);
            Product_Dal.FillDataSet(dataSet);
            DataRelation dataRelation1 = new DataRelation(

            //שם קשר הגומלין

            "OrderProductOrder"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Order"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_OrderProduct"].Columns["Order"]);

            DataRelation dataRelation2 = new DataRelation(

            //שם קשר הגומלין

            "OrderProductProduct"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Product"].Columns["Id"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_OrderProduct"].Columns["Product"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation1);
            dataSet.Relations.Add(dataRelation2);
        }

        public static bool Update(int id, int order, int product, int count)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_OrderProduct SET"
            + $" [Order] = {order}"
            + $",[Product] = {product}"
            + $",[Count] = {count}"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int order)
        {

            //מוחקת את הפריט ממסד הנתונים
            return Dal.ExecuteSql($"DELETE FROM Table_OrderProduct WHERE [Order] = {order}");
        }
    }
}