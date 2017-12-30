using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;

public partial class Categories : System.Web.UI.Page
{
    CategoryRepository catrep = new CategoryRepository();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
            return;

        Bindcategory();


    }

    private void Bindcategory()
    {
        DataSet ds = new DataSet();
        ds = catrep.BindAddcategory();
        rptCategory.DataSource = ds.Tables[0];
        rptCategory.DataBind();
    }

}