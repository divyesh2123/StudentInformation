using StudentInformation.DomainEntity;
using StudentInformation.Repositroy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation.Repositroy.Concreate
{
    public class ProductRepositroy : IProductRepositroy
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();   
            using (NorthwindEntities northwindEntities = new NorthwindEntities())
            {

                products = northwindEntities.Products.ToList();

            }

            return products;
        }
    }
}
