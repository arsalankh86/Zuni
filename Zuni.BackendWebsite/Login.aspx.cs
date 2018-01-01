using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;

public partial class Login : System.Web.UI.Page
{
    AdminRepository adminRepo = new AdminRepository();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lgnButton_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = adminRepo.AuthAdmin(email.Value.ToString(), password.Value.ToString());
        if (dt.Rows.Count >= 1)
        {
            Session["AdminUser"] = dt.Rows[0]["Name"].ToString();
            Response.Redirect("Dashboard.aspx");
        }
    }
}