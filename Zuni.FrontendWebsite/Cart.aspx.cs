using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;
using Zuni.Service.Entities;

public partial class Cart : System.Web.UI.Page
{
 
        CustomerRepository customerRep = new CustomerRepository();
        OrderRepository orderRep = new OrderRepository();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;
        BindCart();
        BindCustomer();
    }

    private void BindCustomer()
    {
        ddlCustomer.Items.Insert(0, new ListItem("Select", "0"));
        DataSet ds = customerRep.GetAllCustomer();
        
        ddlCustomer.DataSource = ds;
        ddlCustomer.DataTextField = "Email";
        ddlCustomer.DataValueField = "CustomerId";
        ddlCustomer.DataBind();

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



                    
                    //lblsubtotal.Text = value.ToString();
                }

                dtcart = dtSessionCart;

                rptCart.DataSource = dtcart;
                rptCart.DataBind();

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
        catch (Exception ex)
        {
            //Response.Redirect("Wishlist.aspx");
        }

    }

    protected void btnConfirmOrder_Click(object sender, EventArgs e)
    {
        placeOrder("Save & Confirm", (int)Constants.OrderStatus.ConfirmandPendingfordeliver);
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        placeOrder("Save Order", (int)Constants.OrderStatus.SaveOnlyOrder);
    }

    private void placeOrder(string status, int statuscode)
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
        order.OrderStatus = status;
        order.RegisterDate = DateTime.Now;
        order.OrderStatusCode = statuscode;
        order.FirstName = name.Value;
        order.LastName = "";
        order.CustomerId = customer.CustomerId;
        order.AgentId = agentId;
        decimal amount = 0;
        DataTable dtSessionCart = (DataTable)Session["Cart"];
        for (int i = dtSessionCart.Rows.Count - 1; i >= 0; i--)
        {
            DataRow dr = dtSessionCart.Rows[i];
            amount += Convert.ToDecimal(dr[1].ToString());
        }

        order.OrderTotal = amount;
        int OrderNumber = orderRep.InsertOrders(order);

        for (int i = dtSessionCart.Rows.Count - 1; i >= 0; i--)
        {
            DataRow dr = dtSessionCart.Rows[i];

            OrderDetail orderDetail = new OrderDetail();
            //orderDetail.CustomerId = customer.CustomerId;
            //orderDetail.OrderNumber = OrderNumber;
            //orderDetail.ProductId = Convert.ToInt32(dr[0].ToString());
            //orderDetail.OrderedProductPrice = Convert.ToDecimal(dr[1].ToString());
            //orderDetail.Quantity = Convert.ToInt32(dr[2].ToString());
            //orderDetail.OrderedProductName = dr[5].ToString();
            //orderDetail.AgentId = agentId;
            //orderRep.InsertOrdersDetail(orderDetail);
            orderRep.InsertOrdersDetail(OrderNumber, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[5].ToString(), agentId, customer.CustomerId);

        }

        CommunicationRepository comRep = new CommunicationRepository();
        string fromEmail = ConfigurationManager.AppSettings["fromemail"].ToString();
        string username = ConfigurationManager.AppSettings["username"].ToString();
        string password = ConfigurationManager.AppSettings["password"].ToString();
        string toemail = customer.Email;
        string subject = "Confirm Order Email";
        string message = "Your Zuni order has confirmed";

        comRep.SendEmail(fromEmail,toemail, subject, 0, message, username, password);
        comRep.SendMessage();

        Session["Cart"] = null;
        Response.Redirect("Thankyou.aspx");

        

    }


    protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
       

    }

    protected void ddlCustomer_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Customer customer = customerRep.GetCustomerByCustomerId(Convert.ToInt32(ddlCustomer.SelectedValue.ToString()));
        email.Value = customer.Email;
        name.Value = customer.FirstName + customer.LastName;
        phone.Value = customer.Phone;

    }
}
