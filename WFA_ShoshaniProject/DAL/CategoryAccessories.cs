using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WFA_ShoshaniProject.DAL
{
    class CategoryAccessories_Dal
    {
        public static bool Insert(string Name)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_CategoryAccessories"
            + "("
            + "[Name]"
            + ")"
            + " VALUES "
            + "("
            + $"'{Name}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_CategoryAccessories"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {


            if (!dataSet.Tables.Contains("Table_CategoryAccessories"))
                Dal.FillDataSet(dataSet, "Table_CategoryAccessories", "[Name]");

        }
        public static bool Update(string Name, int id)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_CategoryAccessories SET"
            + $" [Name] = '{Name}'"
            + $" WHERE ID={id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //מוחקת את הישוב ממסד הנתונים

            string str = "DELETE FROM Table_CategoryAccessories WHERE ID = " + id;

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
    }
}
