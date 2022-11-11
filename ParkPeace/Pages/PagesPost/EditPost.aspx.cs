using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesPost
{
    public partial class EditPost : System.Web.UI.Page
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
            ClassPost post = DataAccessor.SelectPost(id);
            TextBoxNamePost.Text = post.NamePost;
            TextBoxSalary.Text = post.Salary;
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassPost post = new ClassPost();
            post.IdPost = id;
            post.NamePost = TextBoxNamePost.Text;
            post.Salary = TextBoxSalary.Text;
            DataAccessor.UpdatePost(post);
            Response.Redirect("~/Pages/PagesPost/ListPost.aspx");
        }
    }
}