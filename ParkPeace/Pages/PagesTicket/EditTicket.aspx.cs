using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesTicket
{
    public partial class EditTicket : System.Web.UI.Page
    {
        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                LabelMessage.Text = "Id is not defined!";
                LabelMessage.ForeColor = Color.Red;
                return;
            }

            LabelMessage.Text = string.Empty;
            id = int.Parse(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DropDownListIdAttraction.DataSource = DataAccessor.SelectAttractions();
                DropDownListIdAttraction.DataValueField = "IdAttraction";
                DropDownListIdAttraction.DataTextField = "NameAttraction";
                DropDownListIdAttraction.DataBind();
                BindControls();//добавляет данные в поля
            }
        }
        private void BindControls()
        {
            ClassTicket ticket = DataAccessor.SelectTicket(id);
            DropDownListIdAttraction.SelectedValue = ticket.IdAttraction.ToString();
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassTicket ticket = new ClassTicket();
            ticket.IdTicket = id;
            ticket.IdAttraction = int.Parse(DropDownListIdAttraction.SelectedValue);
            ticket.PurchaseDate = DateTime.Now;
            DataAccessor.UpdateTicket(ticket);
            Response.Redirect("~/Pages/PagesTicket/ListTicket.aspx");
        }
    }
}