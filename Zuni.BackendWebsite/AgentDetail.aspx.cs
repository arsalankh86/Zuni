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
}