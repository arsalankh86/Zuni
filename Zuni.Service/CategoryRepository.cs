using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuni.Service.Entities;

namespace Zuni.Service
{
    public class CategoryRepository
    {

        string ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public DataSet BindAddcategory()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string qry = "select * from Category";
            SqlDataAdapter adp = new SqlDataAdapter(qry, con);
            DataSet ds = new System.Data.DataSet();
            adp.Fill(ds);
            return ds;
        }

        public virtual bool PreInsertCategory(Category entity)
        {

            try
            {
                string sql = @"Insert into Category ( 
				[Name]
				,[SEKeywords]
				,[SEName]
                ,[Description]
				 )
				Values
				(  @Name
				, @SEKeywords
				, @SEName
                ,@Description
				);
				Select scope_identity()";
                SqlParameter[] parameterArray = new SqlParameter[]{
                    new SqlParameter("@Name",entity.Name)
                    , new SqlParameter("@SEKeywords",entity.SeKeywords ?? (object)DBNull.Value)
                    , new SqlParameter("@SEName",entity.SeName)
                      , new SqlParameter("@Description",entity.Description)
                };
                var identity = SqlHelper.ExecuteScalar(this.ConnectionString, CommandType.Text, sql, parameterArray);
                if (identity == DBNull.Value) throw new DataException("Identity column was null as a result of the insert operation.");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet GetCategory()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string qry = "Select CategoryID,Name from Category";
            SqlDataAdapter adp = new SqlDataAdapter(qry, con);
            DataSet ds = new System.Data.DataSet();
            adp.Fill(ds);
            return ds;
        }
    }
}
