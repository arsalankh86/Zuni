using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuni.Service
{
    public class ProductCategoryRepository
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public virtual ProductCategory InsertProductCategory(ProductCategory entity)
        {

            ProductCategory other = new ProductCategory();
            other = entity;
                string sql = @"Insert into ProductCategory ( [ProductID]
				,[CategoryID]
				,[DisplayOrder]
				,[CreatedOn] )
				Values
				( @ProductID
				, @CategoryID
				, @DisplayOrder
				, @CreatedOn );
				Select scope_identity()";
                SqlParameter[] parameterArray = new SqlParameter[]{
                    new SqlParameter("@ProductID",entity.ProductId)
                    , new SqlParameter("@CategoryID",entity.CategoryId)
                    , new SqlParameter("@DisplayOrder",entity.DisplayOrder)
                    , new SqlParameter("@CreatedOn",entity.CreatedOn)};
                var identity = SqlHelper.ExecuteScalar(this.ConnectionString, CommandType.Text, sql, parameterArray);
            return entity;
        }

        public DataSet GetProduct()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string qry = "select * from Product";
            SqlDataAdapter adp = new SqlDataAdapter(qry, con);
            DataSet ds = new System.Data.DataSet();
            adp.Fill(ds);
            return ds;
        }

    }
}
