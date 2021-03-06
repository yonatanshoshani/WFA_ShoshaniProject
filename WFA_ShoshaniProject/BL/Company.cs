using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ShoshaniProject.DAL;
using System.Data;

namespace WFA_ShoshaniProject.BL
{
    public class Company
    {
        private string m_Name;// Company name
        private int m_Id;//Id


        public Company() { }

        public string Name { get => m_Name; set => m_Name = value; }
        public int Id { get => m_Id; set => m_Id = value; }

        public bool Insert()
        {
            return (Company_Dal.Insert(m_Name));
        }

        public Company(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח
            m_Id = (int)dataRow["Id"];
            m_Name = dataRow["Name"].ToString();

        }
        public bool Update()
        {
            return Company_Dal.Update(m_Name, m_Id);
        }

        public override string ToString()
        { return $"{m_Name}"; }

        public bool Delete()
        {
            return Company_Dal.Delete(m_Id);
        }
    }
}
