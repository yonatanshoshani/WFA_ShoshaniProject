using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ShoshaniProject.DAL;
using System.Data;

namespace WFA_ShoshaniProject.BL
{
    public class Client
    {
        private string m_FirstName;//first name
        private string m_LastName;//last name
        private string m_Email;// email
        private string m_PhoneNumber;//phone number 
        private string m_Tz;//id
        private int m_ID;// count
        private City m_city;



        public Client() { }

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public string PhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
        public int ID { get => m_ID; set => m_ID = value; }
        public string Tz { get => m_Tz; set => m_Tz = value; }
        public City city { get => m_city; set => m_city = value; }

        public bool Insert()
        {
            return(Client_Dal.Insert(m_FirstName, m_LastName, m_Email, m_PhoneNumber, m_Tz));
        }

        public Client(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_FirstName = dataRow["FirstName"].ToString();
            m_LastName = dataRow["LastName"].ToString();
            m_Email = dataRow["Email"].ToString();
            m_PhoneNumber = dataRow["PhoneNumber"].ToString();
            m_Tz = dataRow["Tz"].ToString();
            this.m_ID = (int)dataRow["ID"];
            m_city = new City(dataRow.GetParentRow("ClientCity"));
        }
        public bool Update()
        {
            return Client_Dal.Update(m_ID, m_FirstName, m_LastName, m_Tz,m_Email,m_PhoneNumber);
        }

        public override string ToString()
        { return $"{m_LastName} {m_FirstName}"; }

        public bool Delete()
        {
            return Client_Dal.Delete(m_ID);
        }
    }
}
