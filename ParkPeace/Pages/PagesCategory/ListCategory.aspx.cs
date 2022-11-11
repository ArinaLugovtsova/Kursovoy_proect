using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesCategory
{
    public partial class ListCategory : System.Web.UI.Page
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
            GridViewCategory.AutoGenerateColumns = false;
            GridViewCategory.DataSource = DataAccessor.SelectCategory();
            GridViewCategory.DataBind();
        }
        protected void GridViewCategory_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[3].Controls[0]).OnClientClick = "return confirm('Вы уверены, что хотите удалить запись?')";
            }
        }

        protected void GridViewCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewCategory.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteCategory(id);
            BindGrid();
        }

        protected void GridViewCategory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewCategory.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/PagesCategory/EditCategory.aspx?id=" + id);
        }
    }
}