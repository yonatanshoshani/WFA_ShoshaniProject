using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WFA_ShoshaniProject.DAL
{
    class Order_Dal
    {
        public static bool Insert(int client, DateTime date, string Comment)
        {
            string str = "INSERT INTO Table_Order"
            + "("
            + "[Client],[Date],[Comment]"
            + ")"
            + " VALUES "
            + "("
            + $"{client}, '{date:yyyy-MM-dd}', '{Comment}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Order"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Order", "[Client],[Date],[Comment]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
            Client_Dal.FillDataSet(dataSet);
            DataRelation dataRelation1 = new DataRelation(

            //שם קשר הגומלין

            "OrderClient"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Client"].Columns["Id"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Order"].Columns["Client"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation1);
        }

        public static bool Update(int id, int client, DateTime date, string Comment)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Order SET"
            + $" [Client] = {client}"
            + $",[Date] = '{date:yyyy-MM-dd}'"
            + $",[Comment] = '{Comment}'"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את ההזמנה ממסד הנתונים

            string str = $"DELETE FROM Table_Order WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }


    }
}