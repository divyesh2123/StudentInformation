using StudentInformation.BussinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation.Service.Interface
{
    public interface IProducrService
    {
        List<ProductViewModel> GetProducts();

        bool AddProduct(ProductViewModel productViewModel);


        bool DeleteProduct(int productId);

        bool UpdateProduct(ProductViewModel productViewModel, int productId);
    }
}
