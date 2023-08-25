using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class AddArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                lblMsg.Visible = false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ContentDbConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Article values (@id,@title,@content,@date)";
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@content", txtContent.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(txtDate.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                lblMsg.Text = " Sucessfully added";
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error !!!!" + ex.Message;
            }
        }
    }
}