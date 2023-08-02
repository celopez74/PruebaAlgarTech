using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgarBlazor.DataAccess.Repositories;
using TestAlgarBlazor.Infrastructure.DataBase;
using TestAlgarBlazor.Model;

namespace TestAlgarBlazor.BusinessLogic.ApplicationServices
{
    public class ProductApplicationService : IProductApplicationService
    {

        private IProductRepository _productRepository;

        public ProductApplicationService(string connectionString)
        {
            _productRepository = new ProductRepository(connectionString);
        }
        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
