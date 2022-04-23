using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ShoshaniProject.DAL;
using System.Data;

namespace WFA_ShoshaniProject.BL
{
    public class OrderAccessories
    {
        private int m_ID;
        private Order m_Order;
        private Accessories m_Accessories;
        private int m_count;


        public int ID { get => m_ID; set => m_ID = value; }
        public Order Order { get => m_Order; set => m_Order = value; }
        public Accessories Accessories { get => m_Accessories; set => m_Accessories = value; }
        public int Count { get => m_count; set => m_count = value; }

        public OrderAccessories() { }
        public bool Insert()
        {
            return OrderAccessories_Dal.Insert(m_Order.ID, m_Accessories.Id, m_count);
        }

        public OrderAccessories(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["Id"];
            m_Order = new Order(dataRow.GetParentRow("OrderAccessoriesOrder"));
            m_Accessories = new Accessories(dataRow.GetParentRow("OrderAccessoriesAccessories"));
            m_count = (int)dataRow["Count"];
        }


        public bool Update()
        {
            return OrderAccessories_Dal.Update(m_ID, m_Order.ID, m_Accessories.Id, m_count);
        }

        public bool Delete()
        {
            return OrderAccessories_Dal.Delete(m_Order.ID);
        }
        
    }
}