using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesCategory
{
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassCategory category = new ClassCategory();
            category.NameCategory = TextBoxNameCategory.Text;
            category.Description = TextBoxDescription.Text;
            DataAccessor.InsertCategory(category);
            Response.Redirect("~/Pages/PagesCategory/ListCategory.aspx");
        }
    }
}
