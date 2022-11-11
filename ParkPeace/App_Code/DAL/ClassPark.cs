using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ParkPeace.App_Code.DAL
{
    public class ClassPark
    {
            public int IdPark { get; set; }
            public string NamePark { get; set; }
            public string AddressPark { get; set; }
            public DateTime? OpeningTime { get; set; }
            public DateTime? ClosingTime { get; set; }
            public int RowNumb { get; set; }

            public ClassPark()
            {
                IdPark = 0;
                NamePark = string.Empty;
                AddressPark = string.Empty;
                OpeningTime = null;
                ClosingTime = null;
                RowNumb = 0;
            }
            public static ClassPark Map(DataRow dataRow)
            {
                ClassPark result = new ClassPark();
                result.IdPark = (int)dataRow["IdPark"];
                result.NamePark = dataRow["NamePark"].ToString();
                result.AddressPark = dataRow["AddressPark"].ToString();
                result.OpeningTime = dataRow["OpeningTime"] != DBNull.Value ? (DateTime?)dataRow["OpeningTime"] : null;
                result.ClosingTime = dataRow["ClosingTime"] != DBNull.Value ? (DateTime?)dataRow["ClosingTime"] : null;
                return result;
            }
            public static ClassPark Map(DataRow dataRow, int index)
            {
            //Метод для подсчета строк в таблице
                ClassPark result = Map(dataRow);
                result.RowNumb = index;
                return result;
            }
        

    }

}