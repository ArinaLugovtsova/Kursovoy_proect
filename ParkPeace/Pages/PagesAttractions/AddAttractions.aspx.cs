using ParkPeace.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkPeace.Pages.PagesAttractions
{
    public partial class AddAttractions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListIdCategory.DataSource = DataAccessor.SelectCategory();
                DropDownListIdCategory.DataValueField = "IdCategory";
                DropDownListIdCategory.DataTextField = "NameCategory";
                DropDownListIdCategory.DataBind();
            }
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            ClassAttractions attractions = new ClassAttractions();
            attractions.IdCategory = int.Parse(DropDownListIdCategory.SelectedValue);
            attractions.IdPark = 1;
            attractions.NameAttraction = TextBoxNameAttraction.Text;
            attractions.Price = int.Parse(TextBoxPrice.Text);
            
            DataAccessor.InsertAttractions(attractions);
            Response.Redirect("~/Pages/PagesAttractions/ListAttractions.aspx");
        }
    }
}