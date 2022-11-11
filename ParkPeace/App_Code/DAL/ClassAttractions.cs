using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ParkPeace.App_Code.DAL
{
    public class ClassAttractions
    {
        public int IdAttraction { get; set; }
        public int IdPark { get; set; }
        public int IdCategory { get; set; }
        public string NameAttraction { get; set; }
        public int Price { get; set; }
        public int RowNumb { get; set; }

        public ClassAttractions()
        {
            IdAttraction = 0;
            IdPark = 0;
            IdCategory = 0;
            NameAttraction = string.Empty;
            Price = 0;
            RowNumb = 0;
        }
        public static ClassAttractions Map(DataRow dataRow)
        {
            ClassAttractions result = new ClassAttractions();
            result.IdAttraction = (int)dataRow["IdAttraction"];
            result.IdPark = (int)dataRow["IdPark"];
            result.IdCategory = (int)dataRow["IdCategory"];
            result.NameAttraction = dataRow["NameAttraction"].ToString();
            result.Price = (int)dataRow["Price"];
            return result;
        }
        public static ClassAttractions Map(DataRow dataRow, int index)
        {
            //Метод для подсчета строк в таблице
            ClassAttractions result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}