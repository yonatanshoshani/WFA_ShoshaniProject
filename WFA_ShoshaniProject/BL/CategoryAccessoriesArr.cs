using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ShoshaniProject.DAL;
using System.Data;
using System.Collections;

namespace WFA_ShoshaniProject.BL
{
    public class CategoryAccessoriesArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = CategoryAccessories_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            CategoryAccessories curCategoryAccessories;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCategoryAccessories = new CategoryAccessories(dataRow);
                this.Add(curCategoryAccessories);
            }
        }

        public bool IsContains(string CategoryAccessoriesName)
        {

            //בדיקה האם יש ישוב עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as CategoryAccessories).Name == CategoryAccessoriesName)
                    return true;
            return false;
        }
        public CategoryAccessories GetCategoryAccessoriesWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            CategoryAccessories maxCategoryAccessories = new CategoryAccessories();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as CategoryAccessories).Id > maxCategoryAccessories.Id)
                    maxCategoryAccessories = this[i] as CategoryAccessories;

            return maxCategoryAccessories;
        }
    }
}