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
    public partial class Product : System.Web.UI.Page
    {

        CategoryRepository catRep = new CategoryRepository();
        ProductRepository productrep = new ProductRepository();
        ProductCategoryRepository productcatrep = new ProductCategoryRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            if (Request.QueryString["pid"] != null)
            {
                int pid = Convert.ToInt32(Request.QueryString["pid"].ToString());
                BindProductByCategory(pid);
            }
            else
            {
                BindProduct();
            }

        }

        private void BindProductByCategory(int pid)
        {
            DataSet ds = new System.Data.DataSet();
            ds = productrep.GetAllProductByCategoryId(pid);
            if (ds != null)
            {
                rptProduct.DataSource = ds.Tables[0];
                rptProduct.DataBind();
            }
        }

        private void BindProduct()
        {
            DataSet ds = new System.Data.DataSet();
            ds = productrep.GetProduct();
            rptProduct.DataSource = ds.Tables[0];
            rptProduct.DataBind();
        }

        protected void rptProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                int productID = Convert.ToInt32(e.CommandArgument.ToString());
                DataSet product = productrep.GetProductByProductID(productID);
                string quantity = "1";
                    DataTable dt;
                int i = 1;

                    if (Session["Cart"] != null)
                    {
                        dt = (DataTable)Session["Cart"];
                    i += dt.Rows.Count -1;
                    }
                    else
                    {
                        dt = new DataTable();                        
                        dt.Columns.Add("ProductId");
                        dt.Columns.Add("ProductPrice");
                        dt.Columns.Add("Quantity");
                        dt.Columns.Add("CartTotal");
                        dt.Columns.Add("ImageFilenameOverride");
                        dt.Columns.Add("Name");
                        dt.Columns.Add("ShoppingCartRecID");
                        dt.Columns.Add("SNO");
                }

                    DataRow dr = dt.NewRow();

                    dr[0] = productID;
                    dr[1] = Convert.ToDecimal(product.Tables[0].Rows[0]["Profitpriceinrupee"].ToString());
                    dr[2] = quantity;
                    dr[3] = Convert.ToDecimal(Convert.ToInt32(quantity) * Convert.ToDecimal(product.Tables[0].Rows[0]["Profitpriceinrupee"].ToString()));
                    dr[4] = product.Tables[0].Rows[0]["ImageFilenameOverride"].ToString();
                    dr[5] = product.Tables[0].Rows[0]["Name"].ToString();
                    dr[6] = Guid.NewGuid();
                    dr[7] = i;
                    dt.Rows.Add(dr);

                    Session["Cart"] = dt;

                Response.Redirect("Cart.aspx");
                }

            catch (Exception ex)
            {
                //Response.Redirect("Wishlist.aspx");
            }
        }

    }
}