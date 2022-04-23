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
    public class CityArr: ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = City_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            City curCity;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCity = new City(dataRow);
                this.Add(curCity);
            }
        }
        public CityArr Filter(int id, string Name)
        {
            CityArr cityarr= new CityArr();
            City City;
            for (int i = 0; i < this.Count; i++)
            {


                City = (this[i] as City);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id == 0 || City.Id == id)
                && City.Name.ToLower().StartsWith(City.Name.ToLower())
               
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    cityarr.Add(City);
            }
            return cityarr;
        }
        public bool IsContains(string cityName)
        {

            //בדיקה האם יש ישוב עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as City).Name == cityName)
                    return true;
            return false;
        }
        public City GetCityWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            City maxCity = new City();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as City).Id > maxCity.Id)
                    maxCity = this[i] as City;

            return maxCity;
        }
    }
}