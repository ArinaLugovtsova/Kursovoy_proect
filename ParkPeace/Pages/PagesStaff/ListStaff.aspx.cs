using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesStaff
{
    public partial class ListStaff : System.Web.UI.Page
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
            GridViewStaff.AutoGenerateColumns = false;
            GridViewStaff.DataSource = DataAccessor.SelectStaff();
            GridViewStaff.DataBind();
        }
        protected void GridViewStaff_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[7].Controls[0]).OnClientClick = "return confirm('Вы уверены, что хотите удалить запись?')";
            }
        }

        protected void GridViewStaff_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewStaff.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteStaff(id);
            BindGrid();
        }

        protected void GridViewStaff_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewStaff.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/PagesStaff/EditStaff.aspx?id=" + id);
        }

        protected string GetStaffPost(object dataItem)
        {
            ClassPost post = DataAccessor.SelectPost(((ClassStaff)dataItem).IdPost);

            return post.NamePost;
        }
    }
}