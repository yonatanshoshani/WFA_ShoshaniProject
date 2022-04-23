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
    public class CompanyAccessoriesArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = CompanyAccessories_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            CompanyAccessories curCompanyAccessories;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCompanyAccessories = new CompanyAccessories(dataRow);
                this.Add(curCompanyAccessories);
            }
        }
        
        public bool IsContains(string CompanyName)
        {

            //בדיקה האם יש ישוב עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Company).Name == CompanyName)
                    return true;
            return false;
        }
        public CompanyAccessories GetCompanyAccessoriesWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            CompanyAccessories maxCompany = new CompanyAccessories();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as CompanyAccessories).Id > maxCompany.Id)
                    maxCompany = this[i] as CompanyAccessories;

            return maxCompany;
        }
    }
}