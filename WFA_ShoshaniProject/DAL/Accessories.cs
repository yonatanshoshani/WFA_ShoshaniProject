using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WFA_ShoshaniProject.DAL
{
    class Accessories_Dal
    {
        public static bool Insert(int Company, int Category, string Name,int Count)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Accessory"
            + "("
            + "[Company],[Category],[Name],[Count]"
            + ")"
            + " VALUES "
            + "("
            + $"{Company},{Category},'{Name}',{Count}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Accessory"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Accessory", "[Category], [Company]");
            DataRelation dataRelation = null;
            
            CompanyAccessories_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                "AccessoriesCompany",
                dataSet.Tables["Table_CompanyAccessories"].Columns["Id"],
                dataSet.Tables["Table_Accessory"].Columns["Company"]);

            dataSet.Relations.Add(dataRelation);

            CategoryAccessories_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                "AccessoriesCategory",
                dataSet.Tables["Table_CategoryAccessories"].Columns["Id"],
                dataSet.Tables["Table_Accessory"].Columns["Category"]);

            dataSet.Relations.Add(dataRelation);


        }
        public static bool Update(int id, int Company, int Category, int Count)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Accessory SET"
            + $" [Company] = '{Company}'"
            + $",[Category] = '{Category}'"
            + $",[Count] = {Count}"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Accessory WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool UpdateCount(int id, int count)
        {

            // מעדכנת את מלאי המוצר במסד הנתונים
            string str = $"UPDATE Table_Accessory SET [Count] = {count} WHERE ID = {id}";
            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
