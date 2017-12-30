using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;

public partial class Login : System.Web.UI.Page
{
    AgentRepository agentRepo = new AgentRepository();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = agentRepo.AuthAgent(email.Value.ToString(), password.Value.ToString());
        if (dt.Rows.Count >= 1)
        {
            Session["AgentUser"] = dt.Rows[0];
            Response.Redirect("Dashboard.aspx");
        }
    }
}