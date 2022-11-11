using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ParkPeace.App_Code.DAL
{
    public class ClassTicket
    {
        public int IdTicket { get; set; }
        public int IdAttraction { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int RowNumb { get; set; }

        public ClassTicket()
        {
            IdTicket = 0;
            IdAttraction = 0;
            PurchaseDate = null;
            RowNumb = 0;
        }
        public static ClassTicket Map(DataRow dataRow)
        {
            ClassTicket result = new ClassTicket();
            result.IdTicket = (int)dataRow["IdTicket"];
            result.IdAttraction = (int)dataRow["IdAttraction"];
            result.PurchaseDate = dataRow["PurchaseDate"] != DBNull.Value ? (DateTime?)dataRow["PurchaseDate"] : null;
            return result;
        }
        public static ClassTicket Map(DataRow dataRow, int index)
        {
            //Метод для подсчета строк в таблице
            ClassTicket result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}