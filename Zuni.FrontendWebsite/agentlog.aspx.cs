using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;

public partial class agentlog : System.Web.UI.Page
{
    AgentRepository agentRep = new AgentRepository();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        int agentid = 0;
        string latitude = "", longitude = "", address = "";
        if(Request.QueryString["agentid"] != null)
        {
            agentid = Convert.ToInt32(Request.QueryString["agentid"].ToString());
        }
        if (Request.QueryString["latitude"] != null)
        {
            latitude = Request.QueryString["latitude"].ToString();
        }
        if (Request.QueryString["longitude"] != null)
        {
            longitude = Request.QueryString["longitude"].ToString();
        }
        if (Request.QueryString["address"] != null)
        {
            address = Request.QueryString["address"].ToString();
        }

        if(agentid != 0 && latitude != "" && longitude != "")
            agentRep.InsertAgentLog(agentid, latitude, longitude, address);

    }
}