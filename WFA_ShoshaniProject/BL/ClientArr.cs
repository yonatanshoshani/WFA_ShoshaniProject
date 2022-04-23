using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_ShoshaniProject.DAL;
using System.Data;
using System.Collections;
using System.Globalization;
namespace WFA_ShoshaniProject.BL
{
    public class ClientArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Client_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Client curClient;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curClient = new Client(dataRow);
                this.Add(curClient);
            }
        }
        public ClientArr Filter(int id, string lastName, string cellNumber)
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                client = (this[i] as Client);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || client.ID == id)
                && client.LastName.ToLower().StartsWith(lastName.ToLower())
                && (client.PhoneNumber.ToString()).Contains(cellNumber)
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    clientArr.Add(client);
            }
            return clientArr;
        }
        public bool DoesExist(City curCity)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Client).city.Id == curCity.Id)
                    return true;

            return false;
        }
        public Dictionary<string, int> GetDictionary(City city = null)
        {

            //מחזירה משתנה מסוג מילון הכולל עבור כל חודש בשנה מסוימת, כמות ההזמנות לאותו חודש
            CityArr cities = new CityArr();
            cities.Fill();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            if (city != null)
            {
                dictionary.Add(city.Name, this.Filter(city.Id).Count);

                return dictionary;
            }

            for (int i = 0; i < cities.Count-1; i++)
            {

                //אם רוצים את שם החודש בהתאם לשפת מערכת ההפעלה
                
                dictionary.Add((cities[i] as City).Name, this.Filter((cities[i] as City).Id).Count);
            }
            return dictionary;
        }
        public ClientArr Filter(int City)
        {

           
            ClientArr returnArr = new ClientArr();
            foreach (Client item in this)
                if (item.city.Id == City )
                    returnArr.Add(item);
            return returnArr;
        }
        //public SortedDictionary<string, int> GetSortedDictionary()
        //{

        //    // מחזירה משתנה מסוג מילון ממוין עם ערכים רלוונטיים לדוח
        //    SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
        //    CityArr clientsCityArr = this.GetCityArr();
        //    foreach (City curCity in clientsCityArr)
        //        dictionary.Add(curCity.Name, this.Filter(curCity).Count);
        //    return dictionary;
        //}

        public CityArr GetCityArr()
        {
            CityArr cityArr = new CityArr();
            Client c;
            for (int i = 0; i < this.Count; i++)
            {
                c = this[i] as Client;
                if (!cityArr.IsContains(c.city.Name))
                {
                    cityArr.Add(c.city);
                }
            }
            return cityArr;
        }
    }
}