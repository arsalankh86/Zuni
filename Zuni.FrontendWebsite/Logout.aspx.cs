using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Abandon();
        try {
            if (Request.Cookies["agentid"] != null)
            {
                HttpCookie currentUserCookie = HttpContext.Current.Request.Cookies["agentid"];
                HttpContext.Current.Response.Cookies.Remove("agentid");
                currentUserCookie.Expires = DateTime.Now.AddDays(-10);
                currentUserCookie.Value = null;
                HttpContext.Current.Response.SetCookie(currentUserCookie);
            }
        }
        catch(Exception ex)
        {
            
        }
        Response.Redirect("Login.aspx");
    }
}