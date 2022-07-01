using StudentInformation.DomainEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation.Repositroy.Interface
{
    /// <summary>
    /// Product Info
    /// </summary>
    public interface IProductRepositroy
    {
        List<Product> GetProducts();

        bool AddProduct(Product product);

        bool DeleteProduct(int productId);

        bool UpdateProduct(Product product, int productId);

    }
}
