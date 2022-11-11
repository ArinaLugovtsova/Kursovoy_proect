using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesPost
{
    public partial class ListPost : System.Web.UI.Page
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
            GridViewPost.AutoGenerateColumns = false;
            GridViewPost.DataSource = DataAccessor.SelectPost();
            GridViewPost.DataBind();
        }
        protected void GridViewPost_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[3].Controls[0]).OnClientClick = "return confirm('Вы уверены, что хотите удалить запись?')";
            }
        }

        protected void GridViewPost_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewPost.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeletePost(id);
            BindGrid();
        }

        protected void GridViewPost_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewPost.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/PagesPost/EditPost.aspx?id=" + id);
        }
    }
}