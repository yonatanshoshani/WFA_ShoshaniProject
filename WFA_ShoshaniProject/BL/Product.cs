using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ShoshaniProject.DAL;
using System.Data;

namespace WFA_ShoshaniProject.BL
{
    public class Product
    {
        private Company m_Company;//fCompany
        private Category m_Category;//Category
        private string m_Name;//name
        private int m_Id;
        private int m_Count;//count


        public Product() { }

        public Company  Company { get => m_Company; set => m_Company = value; }
        public Category Category { get => m_Category; set => m_Category = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public int Count { get => m_Count; set => m_Count = value; }

        public bool Insert()
        {
            return (Product_Dal.Insert(m_Company.Id, m_Category.Id,Name,m_Count));
        }
        public override string ToString()
        {
            if (m_Count > 0)
                return $"{m_Name}, ({m_Count} In stock)";
            else
                return $"{m_Name}  (Out of stock)";
        }
        public Product(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח
            m_Name = dataRow["Name"].ToString();
            m_Category = new Category(dataRow.GetParentRow("ProductCategory"));
            m_Company = new Company(dataRow.GetParentRow("ProductCompany"));
            this.m_Id = (int)dataRow["Id"];
            this.m_Count = (int)(dataRow["Count"]);
        }
        public bool Update()
        {
            return Product_Dal.Update(m_Id, m_Company.Id, m_Category.Id,m_Count);
        }

        public bool UpdateCount()
        { return Product_Dal.UpdateCount(m_Id, Count); }
        public bool Delete()
        {
            return Product_Dal.Delete(m_Id);
        }
    }
}
