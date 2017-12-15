using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zuni.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        string webcon = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lgnButton_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(webcon);
            SqlDataAdapter da = new SqlDataAdapter("usp_Login", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@uname", SqlDbType.NVarChar).Value = email.Value.ToString();
            da.SelectCommand.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password.Value.ToString();
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count >= 1)
            {
                Session["AdminUser"] = dt.Rows[0]["Username"].ToString();
                Response.Redirect("Dashboard");
            }
        }
    }
}