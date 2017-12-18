using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zuni.Service;
using Zuni.Service.Entities;

namespace Zuni.Admin
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        string webcon = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        CategoryRepository catRep = new CategoryRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (IsPostBack)
                return;

            BindDDlProduct();
            BindGridviw();


        }

        private void BindGridviw()
        {
            SqlConnection con = new SqlConnection(webcon);
            string qry = "select * from Product";
            SqlDataAdapter adp = new SqlDataAdapter(qry, con);
            DataSet ds = new System.Data.DataSet();
            adp.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        private void BindDDlProduct()
        {
            DataSet ds = new System.Data.DataSet();
            ds = catRep.GetCategory();

            ddlCategory.DataValueField = ds.Tables[0].Columns[0].ToString();
            ddlCategory.DataTextField = ds.Tables[0].Columns[1].ToString();
            ddlCategory.DataSource = ds.Tables[0];
            ddlCategory.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ProductRepository productrep = new ProductRepository();
            ProductCategoryRepository productcatrep = new ProductCategoryRepository();

            string name = txtname.Text;
            if (txtname.Text != string.Empty)
            {
                try
                {
                    Product product = new Product();
                    product.Name = txtname.Text.Trim();
                    product.Description = txtDescription.Text.Trim();
                    product.SeName = txtname.Text.Trim().ToLower().Replace(' ', '-').Replace('_', '-').Replace('.', '-');
                    product.SeKeywords = txtname.Text.Trim();
                    product.SeDescription = txtDescription.Text.Trim();
                    product.Summary = txtSummary.Text.Trim();
                    product.InStock = true; //Convert.ToBoolean(Convert.ToInt32(dr["InStock"].ToString().Trim()));
                    product.CreatedOn = DateTime.Now;
                    product.ProductGuid = Guid.NewGuid();

                    //// FileUpload 
                    string domain = ConfigurationManager.AppSettings["ImageDomain"];
                    string image = domain;
                    if (imageFile.HasFile)
                    {
                        string fileExt =
                           Path.GetExtension(imageFile.FileName);

                        if (fileExt == ".png" || fileExt == ".gif" || fileExt == ".jpeg" || fileExt == ".jpg")
                        {
                            try
                           {
                                string trailingPath = Path.GetFileName(imageFile.PostedFile.FileName);
                                string fullPath = Path.Combine(Server.MapPath("Images"), trailingPath);
                                image += "\\Images\\" + trailingPath;
                                imageFile.PostedFile.SaveAs(fullPath);
                                string filedes= "File name: " + imageFile.PostedFile.FileName + "<br>" +
                                    imageFile.PostedFile.ContentLength + " kb<br>" +
                                    "Content type: " +
                                    imageFile.PostedFile.ContentType;
                            }
                            catch (Exception ex)
                            {
                                lblerror.Text = "ERROR: " + ex.Message.ToString();
                            }
                        }
                        else
                        {
                            lblerror.Text = "Only .png, .gif and .jpeg files allowed!";
                        }
                    }
                    else
                    {
                        lblerror.Text = "You have not specified a file.";
                    }



                    //// Product Price
                    product.Costinrupee = Convert.ToDecimal(txtCostinrupee.Text.Trim());
                    product.Profitpriceinrupee = Convert.ToDecimal(txtProfitpriceinrupee.Text.Trim());
                    product.Deleted = 0;

                    //// Image
                    product.ImageFilenameOverride = image;

                    int productid = productrep.PreInsertProduct(product);

                    ProductCategory prodcat = new ProductCategory();
                    prodcat.CategoryId = Convert.ToInt32(ddlCategory.SelectedValue);
                    prodcat.ProductId = productid;
                    prodcat.CreatedOn = DateTime.Now;
                    productcatrep.InsertProductCategory(prodcat);

                    txtname.Text = string.Empty;
                    BindGridviw();


                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString() + " " + name);
                }


            }
            else
            {

            }
        }


        protected void txtCostinrupee_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}