using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ParkPeace.App_Code.DAL
{
    public class ClassPost
    {
        public int IdPost { get; set; }
        public string NamePost { get; set; }
        public string Salary { get; set; }
        public int RowNumb { get; set; }

        public ClassPost()
        {
            IdPost = 0;
            NamePost = string.Empty;
            Salary = string.Empty;
            RowNumb = 0;
        }
        public static ClassPost Map(DataRow dataRow)
        {
            ClassPost result = new ClassPost();
            result.IdPost = (int)dataRow["IdPost"];
            result.NamePost = dataRow["NamePost"].ToString();
            result.Salary = dataRow["Salary"].ToString();
            return result;
        }
        public static ClassPost Map(DataRow dataRow, int index)
        {
            //Метод для подсчета строк в таблице
            ClassPost result = Map(dataRow);
            result.RowNumb = index;
            return result;

        }
    }
}