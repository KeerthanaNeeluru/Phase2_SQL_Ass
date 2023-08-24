using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationAssignment10
{
    public partial class ProductRegistraion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblMsg.Visible = false;
                ddlCat.Items.Add("Electronics");
                ddlCat.Items.Add("Toys");
                ddlCat.Items.Add("Home And Decor");
                ddlCat.Items.Add("Books");
                ddlCat.Items.Add("Ornaments");
                ddlCat.Items.Add("Fashion");
                ddlCat.Items.Add("Beauty");
                ddlCat.Items.Add("Furniture");
            }
            Page.UnobtrusiveValidationMode=UnobtrusiveValidationMode.None;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            lblMsg.Text = "Registration sucessfull";
        }
    }
}