using CodeHub.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CodeHub.Repositories
{
    public class CategoryRepository
    {
        private SqlConnection connection = new SqlConnection(DbConnectionString.ConnectionString);

        public List<Category> GetCategoryList(string user)
        {
            return connection.Query<Category>("SELECT *  FROM Category WHERE Owner=@key ORDER BY RowOrder,CategoryName", new { key = user }).ToList();
        }

        public Category GetCategoryGuid(string user, string id)
        {
            return connection.Query<Category>("SELECT *  FROM Category WHERE Owner=@key and CategoryGuid=@guid", new { key = user, guid=id }).FirstOrDefault();
        }

        public List<vw_Category> GetCategoryMenu(string user)
        {
            return connection.Query<vw_Category>("SELECT *  FROM vw_Category WHERE Owner=@key ORDER BY RowOrder,CategoryName", new { key = user }).ToList();
        }
        public bool SetCategory(string catName, string catDesc, int rowOrder, string user)
        {

            string sql = " INSERT INTO [dbo].[Category]( [CategoryName] ,[Color] ,[Description] ,[RowOrder] ,[Owner]) VALUES (@str1,'#FFF',@str2,@str3,@owner); ";

            object data = new
            {
                str1 = catName,
                str2 = catDesc,
                str3 = rowOrder,
                owner = user

            };

            connection.Execute(sql, data);


            return true;
        }

    }
}