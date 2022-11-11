using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesPost
{
    public partial class AddPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassPost post = new ClassPost();
            post.NamePost = TextBoxNamePost.Text;
            post.Salary = TextBoxSalary.Text;
            DataAccessor.InsertPost(post);
            Response.Redirect("~/Pages/PagesPost/ListPost.aspx");
        }

    }
}