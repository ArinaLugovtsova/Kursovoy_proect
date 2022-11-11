using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesCategory
{
    public partial class EditCategory : System.Web.UI.Page
    {
        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                LabelMessage.Text = "id не определено!";
                LabelMessage.ForeColor = Color.Red;
                return;
            }

            LabelMessage.Text = string.Empty;
            id = int.Parse(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                BindControls();
            }
        }
        private void BindControls()
        {
            ClassCategory category = DataAccessor.SelectCategory(id);
            TextBoxNameCategory.Text = category.NameCategory;
            TextBoxDescription.Text = category.Description;
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassCategory category = new ClassCategory();
            category.IdCategory = id;
            category.NameCategory = TextBoxNameCategory.Text;
            category.Description = TextBoxDescription.Text;
            DataAccessor.UpdateCategory(category);
            Response.Redirect("~/Pages/PagesCategory/ListCategory.aspx");
        }
    }
}