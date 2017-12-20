using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;
using Zuni.Service.Entities;

namespace Zuni.Admin
{
    public partial class Dashboard1 : System.Web.UI.Page
    {
        CustomerRepository customerRepository = new CustomerRepository();
        AgentRepository agentRepository = new AgentRepository();
        OrderRepository orderRepository = new OrderRepository();
        int custoemrCount = 0, agentCount = 0, orderCompletedCount = 0, orderPendingCount=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsCustomer = customerRepository.GetAllCustomer();
            if(dsCustomer != null)
                custoemrCount = dsCustomer.Tables[0].Rows.Count;

            DataSet dsAgent = agentRepository.GetAllAgent();
            if (dsAgent != null)
                agentCount = dsAgent.Tables[0].Rows.Count;

            DataSet dsCompletedOrder = orderRepository.GetAllCompletedOrders();
            if (dsCompletedOrder != null)
                orderCompletedCount = dsCompletedOrder.Tables[0].Rows.Count;

            DataSet dsPendingOrder = orderRepository.GetAllPendingOrders();
            if (dsPendingOrder != null)
                orderPendingCount = dsPendingOrder.Tables[0].Rows.Count;


            lblAgentCount.Text = agentCount.ToString();
            lblCompletedOrderCount.Text = orderCompletedCount.ToString();
            lblPendingOrderCount.Text = orderPendingCount.ToString();
            lblRegisteredCustomerCount.Text = custoemrCount.ToString();


            rptCustomer.DataSource = dsCustomer;
            rptCustomer.DataBind();


            rptAgent.DataSource = dsAgent;
            rptAgent.DataBind();


        }
    }
}