using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesPark
{
    public partial class EditPark : System.Web.UI.Page
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
            ClassPark park = DataAccessor.SelectPark(id);
            TextBoxNamePark.Text = park.NamePark;
            TextBoxAddressPark.Text = park.AddressPark;
            TextBoxOpeningTime.Text = park.OpeningTime != null ? park.OpeningTime.Value.ToShortDateString() : string.Empty;
            TextBoxClosingTime.Text = park.OpeningTime != null ? park.ClosingTime.Value.ToShortDateString() : string.Empty;
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassPark park = new ClassPark();
            park.IdPark = id;
            park.NamePark = TextBoxNamePark.Text;
            park.AddressPark = TextBoxAddressPark.Text;
            park.OpeningTime = DateTime.Parse(TextBoxOpeningTime.Text);
            park.ClosingTime = DateTime.Parse(TextBoxClosingTime.Text);
            DataAccessor.UpdatePark(park);
            Response.Redirect("~/Pages/PagesPark/ListPark.aspx");
        }
    }
}