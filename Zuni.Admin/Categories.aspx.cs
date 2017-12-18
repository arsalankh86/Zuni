using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;
using Zuni.Service.Entities;

namespace Zuni.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        string webcon = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        CategoryRepository catrep = new CategoryRepository();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (IsPostBack)
                return;

            BindAddcategory();




        }
        private void BindAddcategory()
        {
            DataSet ds = new DataSet();
            ds = catrep.BindAddcategory();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtname.Text != string.Empty)
            {
                
                Category cat = new Category();
                cat.Name = txtname.Text.Trim();
                cat.SeKeywords = txtname.Text.Trim();
                cat.SeName = txtname.Text.Trim().ToLower().Replace(' ', '-');
                cat.Description = txtdescription.Text;
                catrep.PreInsertCategory(cat);

                txtname.Text = string.Empty;
                BindAddcategory();
            }
        }
    }
}