using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesStaff
{
    public partial class AddStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListIdPost.DataSource = DataAccessor.SelectPost();
                DropDownListIdPost.DataValueField = "IdPost";
                DropDownListIdPost.DataTextField = "NamePost";
                DropDownListIdPost.DataBind();
            }
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassStaff staff = new ClassStaff();
            staff.IdPark = 1;
            staff.IdPost = int.Parse(DropDownListIdPost.SelectedValue);
            staff.NameStaff = TextBoxNameStaff.Text;
            staff.Number = TextBoxNumber.Text;
            staff.Mail = TextBoxMail.Text;
            staff.BirthDate = DateTime.Parse(TextBoxBirthDate.Text);
            staff.AddressStaff = TextBoxAddressStaff.Text;
            DataAccessor.InsertStaff(staff);
            Response.Redirect("~/Pages/PagesStaff/ListStaff.aspx");
        }

    }
}