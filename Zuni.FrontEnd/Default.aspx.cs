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
    public partial class _Default : Page
    {
        ProductRepository productrep = new ProductRepository();
        CategoryRepository catrep = new CategoryRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
            if (IsPostBack)
                return;

            if(Request.QueryString["catid"]!= null)
            {
                int categoryID = Convert.ToInt32(Request.QueryString["catid"].ToString());
                DataSet dsp = new DataSet();
                dsp = productrep.GetAllProductByCategoryId(categoryID);
                rptViewCart.DataSource = dsp;
                rptViewCart.DataBind();

            }
            else
            {
                DataSet dsp = new DataSet();
                dsp = productrep.GetAllProduct();
                rptViewCart.DataSource = dsp;
                rptViewCart.DataBind();
            }

        }
    }
}