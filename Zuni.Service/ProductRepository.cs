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
    public class ProductRepository
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public int PreInsertProduct(Product entity)
        {
            try
            {
                string sql = @"Insert into Product ( 
				[Name]
				,[Description]
				,[SEKeywords]
				,[SEDescription]
				,[SETitle]
				,[SEName]
				,[ImageFilenameOverride]
				,[CreatedOn]
				,[Costinrupee]
				,[Profitpriceinrupee]
                ,[ProductGUID]
                ,[Summary]
                ,[InStock])
				Values
				( 
				@Name
				, @Description
				, @SEKeywords
				, @SEDescription
				, @SETitle
				, @SEName
				, @ImageFilenameOverride
				, @CreatedOn
				, @Costinrupee
				, @Profitpriceinrupee
                , @ProductGUID
                , @Summary 
                , @InStock
                );
				Select scope_identity()";
                SqlParameter[] parameterArray = new SqlParameter[]{
                    new SqlParameter("@Name",entity.Name)
                    , new SqlParameter("@Description",entity.Description ?? (object)DBNull.Value)
                    , new SqlParameter("@SEKeywords",entity.SeKeywords ?? (object)DBNull.Value)
                    , new SqlParameter("@SEDescription",entity.SeDescription ?? (object)DBNull.Value)
                    , new SqlParameter("@SETitle",entity.SeTitle ?? (object)DBNull.Value)
                    , new SqlParameter("@SEName",entity.SeName ?? (object)DBNull.Value)
                    , new SqlParameter("@ImageFilenameOverride",entity.ImageFilenameOverride ?? (object)DBNull.Value)
                    , new SqlParameter("@CreatedOn",entity.CreatedOn)
                    , new SqlParameter("@Costinrupee",entity.Costinrupee ?? (object)DBNull.Value)
                    , new SqlParameter("@Profitpriceinrupee",entity.Profitpriceinrupee ?? (object)DBNull.Value)
                , new SqlParameter("@ProductGUID",entity.ProductGuid)
                , new SqlParameter("@Summary",entity.Summary)
                , new SqlParameter("@InStock",entity.InStock)
                };
                var identity = SqlHelper.ExecuteScalar(this.ConnectionString, CommandType.Text, sql, parameterArray);
                if (identity == DBNull.Value) throw new DataException("Identity column was null as a result of the insert operation.");
                return Convert.ToInt32(identity);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
