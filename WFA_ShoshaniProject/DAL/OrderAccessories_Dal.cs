using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WFA_ShoshaniProject.DAL
{
    class OrderAccessories_Dal
    {
        public static bool Insert(int order, int Accessories, int count)
        {
            string str = "INSERT INTO Table_OrderAccessory"
            + "("
            + "[Order],[Accesory],[Count]"
            + ")"
            + " VALUES "
            + "("
            + $"{order}, {Accessories}, {count}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_OrderAccessory"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_OrderAccessory", "[Order],[Accesory]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            Order_Dal.FillDataSet(dataSet);
            Accessories_Dal.FillDataSet(dataSet);
            DataRelation dataRelation1 = new DataRelation(

            //שם קשר הגומלין

            "OrderAccessoriesOrder"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Order"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_OrderAccessory"].Columns["Order"]);

            DataRelation dataRelation2 = new DataRelation(

            //שם קשר הגומלין

            "OrderAccessoriesAccessories"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Accessory"].Columns["Id"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_OrderAccessory"].Columns["Accesory"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation1);
            dataSet.Relations.Add(dataRelation2);
        }

        public static bool Update(int id, int order, int Accessories, int count)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_OrderAccessory SET"
            + $" [Order] = {order}"
            + $",[Accesory] = {Accessories}"
            + $",[Count] = {count}"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int order)
        {

            //מוחקת את הפריט ממסד הנתונים
            return Dal.ExecuteSql($"DELETE FROM Table_OrderAccessory WHERE [Order] = {order}");
        }
    }
}