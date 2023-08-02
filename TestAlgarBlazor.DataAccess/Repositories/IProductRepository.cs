using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgarBlazor.Model;

namespace TestAlgarBlazor.DataAccess.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Task<Product> GetProductById(int productId);

    }
}
