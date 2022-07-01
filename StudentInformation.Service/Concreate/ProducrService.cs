using AutoMapper;
using StudentInformation.BussinessEntity;
using StudentInformation.Repositroy.Concreate;
using StudentInformation.Repositroy.Interface;
using StudentInformation.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformation.DomainEntity;

namespace StudentInformation.Service.Concreate
{
    public class ProducrService : IProducrService
    {
        public IProductRepositroy productRepositroy {get; set;}
        public ProducrService(IProductRepositroy _productRepositroy)
        {
            productRepositroy = _productRepositroy;    

        }
        public List<ProductViewModel> GetProducts()
        {
            
            var mydata = productRepositroy.GetProducts();

            var mynewData = mydata.Select(y => new ProductViewModel
            {
                CategoryID = y.CategoryID.Value,
                ProductDescription = y.ProductName,
                ProductName = y.ProductName,
                ProductID = y.ProductID
                

            }).ToList();
            

            return mynewData;

        }

        public bool AddProduct(ProductViewModel productViewModel)
        {
            Product product = new Product();
            product.ProductID = productViewModel.ProductID;
            product.ProductName = productViewModel.ProductName;
            

            return productRepositroy.AddProduct(product);
        }

        public bool DeleteProduct(int productId)
        {
            return productRepositroy.DeleteProduct(productId);
        }

        public bool UpdateProduct(ProductViewModel productViewModel, int productId)
        {
            var product = new Product();
            product.ProductName = productViewModel.ProductName;
            product.ProductID = productViewModel.ProductID;

            return productRepositroy.UpdateProduct(product,productId);
        }
    }
}
