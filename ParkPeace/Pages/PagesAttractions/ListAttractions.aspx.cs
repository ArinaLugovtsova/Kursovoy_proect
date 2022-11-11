using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesAttractions
{
    public partial class ListAttractions : System.Web.UI.Page
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
            GridViewAttractions.AutoGenerateColumns = false;
            GridViewAttractions.DataSource = DataAccessor.SelectAttractions();
            GridViewAttractions.DataBind();
        }
        protected void GridViewAttractions_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[4].Controls[0]).OnClientClick = "return confirm('Вы уверены, что хотите удалить запись?')";
            }
        }

        protected void GridViewAttractions_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewAttractions.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteAttractions(id);
            BindGrid();
        }

        protected void GridViewAttractions_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewAttractions.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/PagesAttractions/EditAttractions.aspx?id=" + id);
        }


        protected string GetAttractionCategory(object dataItem)
        {
            ClassCategory category = DataAccessor.SelectCategory(((ClassAttractions)dataItem).IdCategory);

            return category.NameCategory;
        }
    }
}