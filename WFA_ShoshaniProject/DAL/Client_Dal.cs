using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WFA_ShoshaniProject.DAL
{
    class Client_Dal
    {
        public static bool Insert(string firstName, string lastName, string email, string phoneNumber, string tz)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[Email], [PhoneNumber],[Tz]"
            + ")"
            + " VALUES "
            + "("
            + $"'{firstName}','{lastName}','{email}','{phoneNumber}',{tz}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Client", "[LastName], [FirstName]");
            DataRelation dataRelation = null;
            City_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                "ClientCity",
                dataSet.Tables["Table_City"].Columns["Id"],
                dataSet.Tables["Table_Client"].Columns["City"]);

            dataSet.Relations.Add(dataRelation);
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...

        }
        public static bool Update(int id, string firstName, string lastName, string email, string phoneNumber, string tz)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [FirstName] = '{firstName}'"
            + $",[LastName] = '{lastName}'"
            + $",[Email] = '{email}'"
            + $",[PhoneNumber] = '{phoneNumber}'"
            + $",[Tz] = {tz}"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Client WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}
