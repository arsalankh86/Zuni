using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zuni.Admin
{
    public partial class Zuni : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["AdminUser"] == null)
                    Response.Redirect("Login.aspx");

                lbladmin.Text = Session["AdminUser"].ToString();
            }
        }

        protected void lnklogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");

        }



    }
}