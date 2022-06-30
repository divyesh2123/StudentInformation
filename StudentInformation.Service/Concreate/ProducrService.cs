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
    }
}
