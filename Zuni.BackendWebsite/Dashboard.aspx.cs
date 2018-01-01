using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;
using Zuni.Service.Entities;

public partial class Dashboard : System.Web.UI.Page
{
    CustomerRepository customerRepository = new CustomerRepository();
    AgentRepository agentRepository = new AgentRepository();
    OrderRepository orderRepository = new OrderRepository();
    int custoemrCount = 0, agentCount = 0, orderConfirmCount = 0, orderSaveOnlyCount = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet dsCustomer = customerRepository.GetAllCustomer();
        if (dsCustomer != null)
            custoemrCount = dsCustomer.Tables[0].Rows.Count;

        DataSet dsAgent = agentRepository.GetAllAgent();
        if (dsAgent != null)
            agentCount = dsAgent.Tables[0].Rows.Count;

        DataSet dsOrder = orderRepository.GetAllOrders();

        DataSet dsConfirmdOrder = orderRepository.GetAllConfirmOrders();
        if (dsConfirmdOrder != null)
            orderConfirmCount = dsConfirmdOrder.Tables[0].Rows.Count;

        DataSet dsSaveOnlyOrder = orderRepository.GetAllSaveOnlyOrders();
        if (dsSaveOnlyOrder != null)
            orderSaveOnlyCount = dsSaveOnlyOrder.Tables[0].Rows.Count;


        lblAgentCount.Text = agentCount.ToString();
        lblConfirmOrderCount.Text = orderConfirmCount.ToString();
        lblSaveOrderCount.Text = orderSaveOnlyCount.ToString();
        lblRegisteredCustomerCount.Text = custoemrCount.ToString();


        rptCustomer.DataSource = dsCustomer;
        rptCustomer.DataBind();


        rptAgent.DataSource = dsAgent;
        rptAgent.DataBind();

        rptOrder.DataSource = dsOrder;
        rptOrder.DataBind();


    }
}