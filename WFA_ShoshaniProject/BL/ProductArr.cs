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
    public class ProductArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Product_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Product curProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curProduct = new Product(dataRow);
                this.Add(curProduct);
            }
        }
        public ProductArr Filter(string name, Company company, Category category)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Product product = (this[i] as Product);
                if (

                //סינון לפי שם המוצר

                product.Name.StartsWith(name)

                //סינון לפי החברה
                && (company == null || company.Id == -1 || product.Company.Id == company.Id)
                //סינון לפי קטגוריה
                && (category == null || category.Id == -1 || product.Category.Id == category.Id)
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    productArr.Add(product);
            }
            return productArr;
        }

        public bool DoesExist(Category curCategory)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Company.Id == curCategory.Id)
                    return true;

            return false;
        }
        public bool DoesExist(Company curCompany)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Company.Id == curCompany.Id)
                    return true;

            return false;
        }
        public void Remove(ProductArr productArr)
        {

            //מסירה מהאוסף הנוכחי את האוסף המתקבל

            for (int i = 0; i < productArr.Count; i++)
                this.Remove(productArr[i] as Product);
        }
        public void Remove(Product product)
        {

            //מסירה מהאוסף הנוכחי את הפריט המתקבל

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Id == product.Id)
                {
                    this.RemoveAt(i); return;
                }
        }
        public void UpdateCount()
        {

            //מעדכנת את אוסף המוצרים

            for (int i = 0; i < this.Count; i++)
                (this[i] as Product).UpdateCount();
        }
        public void UpdateProduct(Product product)
        {

            //מעדכנת את הכמות של הפריט באוסף הנוכחי

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Id == product.Id)
                {
                    this[i] = product;
                    return;
                }
        }
    }
}