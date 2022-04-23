using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WFA_ShoshaniProject.DAL
{
    class Product_Dal
    {
        public static bool Insert(int Company, int Category, string Name,int Count)
        {

  

            string str = "INSERT INTO Table_Product"
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
            dataTable = dataSet.Tables["Table_Product"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Product", "[Id], [Category], [Company]");
            DataRelation dataRelation = null;
            
            Company_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                "ProductCompany",
                dataSet.Tables["Table_Company"].Columns["Id"],
                dataSet.Tables["Table_Product"].Columns["Company"]);

            dataSet.Relations.Add(dataRelation);

            Category_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                "ProductCategory",
                dataSet.Tables["Table_Category"].Columns["Id"],
                dataSet.Tables["Table_Product"].Columns["Category"]);

            dataSet.Relations.Add(dataRelation);


        }
        public static bool Update(int id, int Company, int Category, int Count)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Product SET"
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

            string str = $"DELETE FROM Table_Product WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }

        public static bool UpdateCount(int id, int count)
        {

            // מעדכנת את מלאי המוצר במסד הנתונים
            string str = $"UPDATE Table_Product SET [Count] = {count} WHERE ID = {id}";
            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}
