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
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            if (name.Value != "" && phone.Value != "" && email.Value != "")
            {
                CustomerRepository customerRep = new CustomerRepository();
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


                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                lblerror.Text = "Please Fill Form Correctly";
            }
        }
    }
}