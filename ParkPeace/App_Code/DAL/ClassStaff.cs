using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ParkPeace.App_Code.DAL
{
    public class ClassStaff
    {
        public int IdStaff { get; set; }
        public int IdPost { get; set; }
        public int IdPark { get; set; }
        public string NameStaff { get; set; }
        public string Number { get; set; }
        public string Mail { get; set; }
        public DateTime? BirthDate { get; set; }
        public string AddressStaff { get; set; }
        public int RowNumb { get; set; }

        public ClassStaff()
        {
            IdStaff = 0;
            IdPost = 0;
            IdPark = 0;
            NameStaff = string.Empty;
            Number = string.Empty;
            Mail = string.Empty;
            BirthDate = null;
            AddressStaff = string.Empty;
            RowNumb = 0;
        }
        public static ClassStaff Map(DataRow dataRow)
        {
            ClassStaff result = new ClassStaff();
            result.IdStaff = (int)dataRow["IdStaff"];
            result.IdPost = (int)dataRow["IdPost"];
            result.IdPark = (int)dataRow["IdPark"];
            result.NameStaff = dataRow["NameStaff"].ToString();
            result.Number = dataRow["Number"].ToString();
            result.Mail = dataRow["Mail"].ToString();
            result.BirthDate = dataRow["BirthDate"] != DBNull.Value ? (DateTime?)dataRow["BirthDate"] : null;
            result.AddressStaff = dataRow["AddressStaff"].ToString();
            return result;
        }
        public static ClassStaff Map(DataRow dataRow, int index)
        {
            //Метод для подсчета строк в таблице
            ClassStaff result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}