using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;
using Zuni.Service.Entities;

namespace Zuni.FrontEnd
{
    public partial class Cart : System.Web.UI.Page
    {
        CustomerRepository customerRep = new CustomerRepository();
        OrderRepository orderRep = new OrderRepository();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            BindCart();
        }

        private void BindCart()
        {

            string productids = string.Empty;
            decimal value = 0;
            DataSet dsShoppingCart = new DataSet();
            DataTable dtcart = new DataTable();
            {
                if (Session["Cart"] != null)
                {
                    DataTable dtSessionCart = (DataTable)Session["Cart"];

                    if (dtSessionCart.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dtSessionCart.Rows)
                        {
                            value += Convert.ToDecimal(dr[3].ToString());
                        }

                        int quantity = 0;
                        for (int i = 0; i < dtSessionCart.Rows.Count; i++)
                        {
                            quantity += Convert.ToInt32(dtSessionCart.Rows[i]["Quantity"].ToString());
                        }



                        dtcart = dtSessionCart;

                        rptCart.DataSource = dtcart;
                        rptCart.DataBind();
                        //lblsubtotal.Text = value.ToString();
                    }

                }
            }



        }

        protected void rptCart_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "LinkRemove")
                {
                    
                        string id = e.CommandArgument.ToString();
                        DataTable dtSessionCart = (DataTable)Session["Cart"];
                        for (int i = dtSessionCart.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dtSessionCart.Rows[i];
                            if (dr["ShoppingCartRecID"].ToString() == id)
                                dr.Delete();
                        }
                        Session["Cart"] = dtSessionCart;
                    
                }

                BindCart();

            }
            catch(Exception ex)
            {
                //Response.Redirect("Wishlist.aspx");
            }

        }

        protected void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            int agentId = 0;
            if(Session["AgentUser"] != null)
            {
                DataRow dr = (DataRow)Session["AgentUser"];
                agentId = Convert.ToInt32(dr[0].ToString());
            }

            Customer customer = new Customer();
            customer.FirstName = name.Value;
            customer.LastName = "";
            customer.Email = email.Value;
            customer.Phone = phone.Value;
            customer.AgentId = agentId;

            customer = customerRep.PreInsertCustomer(customer);

            Orders order = new Orders();
            order.Phone = phone.Value;
            order.Email = email.Value;
            order.OrderDate = DateTime.Now;
            order.OrderGuid = new Guid();
            order.OrderStatus = "Confirm & Pending for Delivery";
            order.RegisterDate = DateTime.Now;
            order.OrderStatusCode = (int)Constants.OrderStatus.ConfirmandPendingfordeliver;
            order.FirstName = name.Value;
            order.LastName = "";
            order.CustomerId = customer.CustomerId;
            order.AgentId = agentId;
            order.OrderDate = DateTime.Now;

            OrderRepository orderRepository = new OrderRepository();
            int OrderNumber = orderRepository.InsertOrders(order);

            DataTable dtSessionCart = (DataTable)Session["Cart"];
            for (int i = dtSessionCart.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dtSessionCart.Rows[i];
                
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.CustomerId = customer.CustomerId;
                orderDetail.OrderNumber = OrderNumber;
                
                orderDetail.ProductId = Convert.ToInt32(dr[0].ToString());
                orderDetail.OrderedProductPrice = Convert.ToDecimal(dr[1].ToString());
                orderDetail.Quantity = Convert.ToInt32(dr[2].ToString());
                orderDetail.OrderedProductName = dr[5].ToString();
                orderDetail.AgentId = agentId;
                orderDetail.CreatedOn = DateTime.Now;
                orderRep.InsertOrdersDetail(orderDetail);

            }
            Response.Redirect("Thankyou.aspx");
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            int agentId = 0;
            if (Session["AgentUser"] != null)
            {
                DataRow dr = (DataRow)Session["AgentUser"];
                agentId = Convert.ToInt32(dr[0].ToString());
            }

            Customer customer = new Customer();
            customer.FirstName = name.Value;
            customer.LastName = "";
            customer.Email = email.Value;
            customer.Phone = phone.Value;
            customer.AgentId = agentId;

            customer = customerRep.PreInsertCustomer(customer);

            Orders order = new Orders();
            order.Phone = phone.Value;
            order.Email = email.Value;
            order.OrderDate = DateTime.Now;
            order.OrderGuid = new Guid();
            order.OrderStatus = "Only Save Order";
            order.RegisterDate = DateTime.Now;
            order.OrderStatusCode = (int)Constants.OrderStatus.SaveOnlyOrder;
            order.FirstName = name.Value;
            order.LastName = "";
            order.CustomerId = customer.CustomerId;

            OrderRepository orderRepository = new OrderRepository();
            int OrderNumber = orderRepository.InsertOrders(order);

            DataTable dtSessionCart = (DataTable)Session["Cart"];
            for (int i = dtSessionCart.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dtSessionCart.Rows[i];

                OrderDetail orderDetail = new OrderDetail();
                orderDetail.CustomerId = customer.CustomerId;
                orderDetail.OrderNumber = OrderNumber;

                orderDetail.ProductId = Convert.ToInt32(dr[0].ToString());
                orderDetail.OrderedProductPrice = Convert.ToDecimal(dr[1].ToString());
                orderDetail.Quantity = Convert.ToInt32(dr[2].ToString());
                orderDetail.OrderedProductName = dr[5].ToString();
                orderRep.InsertOrdersDetail(orderDetail);

            }
            Response.Redirect("Thankyou.aspx");
        }
    }
}