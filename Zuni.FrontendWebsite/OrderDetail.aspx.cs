using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;

public partial class OrderDetail : System.Web.UI.Page
{
    OrderRepository orderRepository = new OrderRepository();
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

       

        if(Request.QueryString["ordercode"] != null)
        {
            pnlorderdetail.Visible = true;
            int ordercode = Convert.ToInt32(Request.QueryString["ordercode"].ToString());
            DataSet ds = orderRepository.GetOrderDetailByOrderCode(ordercode);

            rptOrderdetail.DataSource = ds;
            rptOrderdetail.DataBind();
        }

        BindOrder(agentId);
    }

    private void BindOrder(int agentId)
    {

       
        DataSet ds = new DataSet();
        ds = orderRepository.GetAllOrderByAgent(agentId);

        rptOrder.DataSource = ds;
        rptOrder.DataBind();
    }
}