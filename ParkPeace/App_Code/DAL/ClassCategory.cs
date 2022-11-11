using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ParkPeace.App_Code.DAL
{
    public class ClassCategory
    {

        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
        public string Description { get; set; }
        public int RowNumb { get; set; }

        public ClassCategory()
        {
            IdCategory = 0;
            NameCategory = string.Empty;
            Description = string.Empty;
            RowNumb = 0;
        }
        public static ClassCategory Map(DataRow dataRow)
        {
            ClassCategory result = new ClassCategory();
            result.IdCategory = (int)dataRow["IdCategory"];
            result.NameCategory = dataRow["NameCategory"].ToString();
            result.Description = dataRow["Description"].ToString();
            return result;
        }
        public static ClassCategory Map(DataRow dataRow, int index)
        {
            //Метод для подсчета строк в таблице
            ClassCategory result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}