using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;

public partial class AgentDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AgentRepository agentRepository = new AgentRepository();
        DataSet dsAgent = agentRepository.GetAllAgent();
        rptAgent.DataSource = dsAgent;
        rptAgent.DataBind();

    }


    protected void btnCreateAgent_Click(object sender, EventArgs e)
    {
        if (name.Value != "" && password.Value != "" && email.Value != "")
        {
            AgentRepository agentRepository = new AgentRepository();
            int agentId = 0;
            if (Session["AgentUser"] != null)
            {
                DataRow dr = (DataRow)Session["AgentUser"];
                agentId = Convert.ToInt32(dr[0].ToString());
            }

            agentRepository.AddAgent(name.Value, email.Value, password.Value);
            Response.Redirect("Dashboard.aspx");
        }
        else
        {
            lblerror.Text = "Please Fill Form Correctly";
        }
    }
}