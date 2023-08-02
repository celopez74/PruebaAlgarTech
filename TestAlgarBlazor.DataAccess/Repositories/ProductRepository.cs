using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgarBlazor.Model;

namespace TestAlgarBlazor.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public String ConnectionString;
        public ProductRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection dbConnect()
        {
            
            
            return new SqlConnection(ConnectionString);
        }
        public  List<Product> GetAllProducts()
        {
            var db = dbConnect();

            var result =  db.Query<Product>("GET_ALL_PRODUCTS", null, commandType: CommandType.StoredProcedure).ToList();

            return result;

        }

        public Task<Product> GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
