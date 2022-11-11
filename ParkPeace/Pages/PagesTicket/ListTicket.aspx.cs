using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesTicket
{
    public partial class ListTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            GridViewTicket.AutoGenerateColumns = false;
            GridViewTicket.DataSource = DataAccessor.SelectTicket();
            GridViewTicket.DataBind();
        }
        protected void GridViewTicket_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[4].Controls[0]).OnClientClick = "return confirm('Вы уверены, что хотите удалить запись?')";
            }
        }

        protected void GridViewTicket_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewTicket.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteTicket(id);
            BindGrid();
        }

        protected void GridViewTicket_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewTicket.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/PagesTicket/EditTicket.aspx?id=" + id);
        }

        protected string GetTicketAttraction(object dataItem)
        {
            ClassAttractions attractions = DataAccessor.SelectAttractions(((ClassTicket)dataItem).IdAttraction);

            return attractions.NameAttraction;
        }

        protected string GetTicketPrice(object dataItem)
        {
            ClassAttractions attractions = DataAccessor.SelectAttractions(((ClassTicket)dataItem).IdAttraction);

            return attractions.Price.ToString();
        }
    }
}