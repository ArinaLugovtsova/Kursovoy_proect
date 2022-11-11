using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesPark
{
    public partial class ListPark : System.Web.UI.Page
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
            GridViewPark.AutoGenerateColumns = false;
            GridViewPark.DataSource = DataAccessor.SelectPark();
            GridViewPark.DataBind();
        }

        protected void GridViewPark_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewPark.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeletePark(id);
            BindGrid();
        }
        protected void GridViewPark_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[5].Controls[0]).OnClientClick = "return confirm('Вы уверены, что хотите удалить запись?');";
            }
        }

        protected void GridViewPark_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewPark.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/PagesPark/EditPark.aspx?id=" + id);
        }

    }
}