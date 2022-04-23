using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ShoshaniProject.DAL;
using System.Data;

namespace WFA_ShoshaniProject.BL
{
    public class Order
    {
        private string m_Comment;
        private int m_ID;
        private DateTime m_Date;
        private Client m_Client;


        public int ID { get => m_ID; set => m_ID = value; }
        public string Comment { get => m_Comment; set => m_Comment = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }
        public Client Client { get => m_Client; set => m_Client = value; }

        public Order() { }
        public bool Insert()
        {
            return Order_Dal.Insert(m_Client.ID, m_Date, m_Comment);
        }

        public Order(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["ID"];
            m_Client = new Client(dataRow.GetParentRow("OrderClient"));
            m_Date = (DateTime)dataRow["Date"];
            m_Comment = dataRow["Comment"].ToString();
        }

        public bool Delete()
        {
            return Order_Dal.Delete(m_ID);
        }
        public bool Update()
        {
            return Order_Dal.Update(m_ID, m_Client.ID, m_Date, m_Comment);
        }
        public override string ToString()
        { return $"{m_ID} {m_Client.FirstName} {m_Client.LastName}"; }


    }
}