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
    internal interface IProductRepositroy
    {
        List<Product> GetProducts();
    }
}
