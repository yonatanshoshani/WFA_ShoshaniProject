using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ShoshaniProject.DAL;
using System.Data;

namespace WFA_ShoshaniProject.BL
{
    public class OrderProduct
    {
        private int m_ID;
        private Order m_Order;
        private Product m_Product;
        private int m_Count;


        public int ID { get => m_ID; set => m_ID = value; }
        public Order Order { get => m_Order; set => m_Order = value; }
        public Product Product { get => m_Product; set => m_Product = value; }
        public int Count { get => m_Count; set => m_Count = value; }

        public OrderProduct() { }
        public bool Insert()
        {
            return OrderProduct_Dal.Insert(m_Order.ID, m_Product.Id, m_Count);
        }

        public OrderProduct(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["Id"];
            m_Order = new Order(dataRow.GetParentRow("OrderProductOrder"));
            m_Product = new Product(dataRow.GetParentRow("OrderProductProduct"));
            m_Count = (int)dataRow["Count"];
        }


        public bool Update()
        {
            return OrderProduct_Dal.Update(m_ID, m_Order.ID, m_Product.Id, m_Count);
        }

        public bool Delete()
        {
            return OrderProduct_Dal.Delete(m_Order.ID);
        }
        
    }
}