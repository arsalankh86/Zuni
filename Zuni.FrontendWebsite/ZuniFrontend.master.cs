using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ZuniFrontend : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AgentUser"] != null)
        {
            DataRow dr = (DataRow)Session["AgentUser"];

        }
        else
            Response.Redirect("Login.aspx");
    }
}
