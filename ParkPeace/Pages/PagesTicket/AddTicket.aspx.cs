using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesTicket
{
    public partial class AddTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListIdAttraction.DataSource = DataAccessor.SelectAttractions();
                DropDownListIdAttraction.DataValueField = "IdAttraction";
                DropDownListIdAttraction.DataTextField = "NameAttraction";
                DropDownListIdAttraction.DataBind();
            }
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassTicket ticket = new ClassTicket();
            ticket.IdAttraction = int.Parse(DropDownListIdAttraction.SelectedValue);
            ticket.PurchaseDate = DateTime.Now;
            DataAccessor.InsertTicket(ticket);
            Response.Redirect("~/Pages/PagesTicket/ListTicket.aspx");
        }
    }
}