using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgarBlazor.Model;

namespace TestAlgarBlazor.BusinessLogic.ApplicationServices
{
    public interface IProductApplicationService
    {
        List<Product> GetAllProducts();
    }
}
