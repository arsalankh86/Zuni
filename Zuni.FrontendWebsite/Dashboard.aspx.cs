using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AgentUser"] != null)
        {
            DataRow dr = (DataRow)Session["AgentUser"];
            lblagentname.Text = dr["Name"].ToString() + "  (" + dr["UserName"].ToString() + ")"; // + "at " + DateTime.Now;
        }


        
    }
}