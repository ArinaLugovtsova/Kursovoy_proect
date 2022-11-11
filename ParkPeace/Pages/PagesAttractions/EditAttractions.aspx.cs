using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesAttractions
{
    public partial class EditAttractions : System.Web.UI.Page
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
                DropDownListIdCategory.DataSource = DataAccessor.SelectCategory();
                DropDownListIdCategory.DataValueField = "IdCategory";
                DropDownListIdCategory.DataTextField = "NameCategory";
                DropDownListIdCategory.DataBind();
                BindControls();//добавляет данные в поля
            }
        }
        private void BindControls()
        {
            ClassAttractions attractions = DataAccessor.SelectAttractions(id);
            DropDownListIdCategory.SelectedValue = attractions.IdCategory.ToString();
            TextBoxNameAttraction.Text = attractions.NameAttraction;
            TextBoxPrice.Text = attractions.Price.ToString();
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassAttractions attractions = new ClassAttractions();
            attractions.IdAttraction = id;
            attractions.IdCategory = int.Parse(DropDownListIdCategory.SelectedValue);
            attractions.NameAttraction = TextBoxNameAttraction.Text;
            attractions.Price = int.Parse(TextBoxPrice.Text);

            DataAccessor.UpdateAttractions(attractions);
            Response.Redirect("~/Pages/PagesAttractions/ListAttractions.aspx");
        }
    }
}