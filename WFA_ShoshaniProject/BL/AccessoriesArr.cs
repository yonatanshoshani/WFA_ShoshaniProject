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
    public class AccessoriesArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Accessories_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Accessories curAccessories;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curAccessories = new Accessories(dataRow);
                this.Add(curAccessories);
            }
        }
        public AccessoriesArr Filter(string name, CompanyAccessories company, CategoryAccessories category)
        {
            AccessoriesArr AccessoriesArr = new AccessoriesArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Accessories Accessories = (this[i] as Accessories);
                if (

                //סינון לפי שם המוצר

                Accessories.Name.StartsWith(name)

                //סינון לפי החברה
                && (company == null || company.Id == -1 || Accessories.Company.Id == company.Id)
                //סינון לפי קטגוריה
                && (category == null || category.Id == -1 || Accessories.Category.Id == category.Id)
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    AccessoriesArr.Add(Accessories);
            }
            return AccessoriesArr;
        }
        public bool DoesExist(CategoryAccessories curCategory)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Accessories).Company.Id == curCategory.Id)
                    return true;

            return false;
        }
        public bool DoesExist(CompanyAccessories curCompany)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Accessories).Company.Id == curCompany.Id)
                    return true;

            return false;
        }
        public void Remove(AccessoriesArr AccessoriesArr)
        {

            //מסירה מהאוסף הנוכחי את האוסף המתקבל

            for (int i = 0; i < AccessoriesArr.Count; i++)
                this.Remove(AccessoriesArr[i] as Accessories);
        }
        public void Remove(Accessories Accessories)
        {

            //מסירה מהאוסף הנוכחי את הפריט המתקבל

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Accessories).Id == Accessories.Id)
                {
                    this.RemoveAt(i); return;
                }
        }
        public void UpdateCount()
        {

            //מעדכנת את אוסף המוצרים

            for (int i = 0; i < this.Count; i++)
                (this[i] as Accessories).UpdateCount();
        }
        public void UpdateAccessories(Accessories Accessories)
        {

            //מעדכנת את הכמות של הפריט באוסף הנוכחי

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Accessories).Id == Accessories.Id)
                {
                    this[i] = Accessories;
                    return;
                }
        }
    }
}