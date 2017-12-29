using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;

namespace Zuni.FrontEnd
{
    public partial class CustomerDetail : System.Web.UI.Page
    {
        CustomerRepository customerRepository = new CustomerRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            int agentId = 0;
            if (Session["AgentUser"] != null)
            {
                DataRow dr = (DataRow)Session["AgentUser"];
                agentId = Convert.ToInt32(dr[0].ToString());
            }

            DataSet ds = new DataSet();
            ds = customerRepository.GetAllCustomerByAgent(agentId);

            rptCustomer.DataSource = ds;
            rptCustomer.DataBind();


        }


    }
}