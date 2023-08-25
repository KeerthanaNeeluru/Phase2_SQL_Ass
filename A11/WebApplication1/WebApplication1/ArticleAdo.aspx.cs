using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ArticleAdo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=LAPTOP-PNAP8MRF;database=ContentDb;trusted_connection=true;");
                SqlCommand cmd = new SqlCommand("select * from Article", con);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                lblMsg.Text = "Number of Articles are : " + ds.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error !!!!" + ex.Message;
            }
        }

    }
}