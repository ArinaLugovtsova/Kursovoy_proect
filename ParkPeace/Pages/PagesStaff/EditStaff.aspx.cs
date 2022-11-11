using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesStaff
{
    public partial class EditStaff : System.Web.UI.Page
    {
        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                LabelMessage.Text = "Id is not defined!";
                LabelMessage.ForeColor = Color.Red;
                return;
            }

            LabelMessage.Text = string.Empty;
            id = int.Parse(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DropDownListIdPost.DataSource = DataAccessor.SelectPost();
                DropDownListIdPost.DataValueField = "IdPost";
                DropDownListIdPost.DataTextField = "NamePost";
                DropDownListIdPost.DataBind();
                BindControls();//добавляет данные в поля
            }
        }
        private void BindControls()
        {
            ClassStaff staff = DataAccessor.SelectStaff(id);
            DropDownListIdPost.SelectedValue = staff.IdPost.ToString();
            TextBoxNameStaff.Text = staff.NameStaff;
            TextBoxNumber.Text = staff.Number;
            TextBoxMail.Text = staff.Mail;
            TextBoxAddressStaff.Text = staff.AddressStaff;
            TextBoxBirthDate.Text = staff.BirthDate != null ? staff.BirthDate.Value.ToShortDateString() : string.Empty;
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassStaff staff = new ClassStaff();
            staff.IdStaff = id;
            staff.IdPost = int.Parse(DropDownListIdPost.SelectedValue);
            staff.NameStaff = TextBoxNameStaff.Text;
            staff.Number = TextBoxNumber.Text;
            staff.Mail = TextBoxMail.Text;
            staff.AddressStaff = TextBoxAddressStaff.Text;
            staff.BirthDate = DateTime.Parse(TextBoxBirthDate.Text);
            DataAccessor.UpdateStaff(staff);
            Response.Redirect("~/Pages/PagesStaff/ListStaff.aspx");
        }
    }
}