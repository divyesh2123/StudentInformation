using AutoMapper;
using StudentInformation.BussinessEntity;
using StudentInformation.Repositroy.Concreate;
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
        public ProductRepositroy productRepositroy {get; set;}
        public ProducrService()
        {
            productRepositroy = new ProductRepositroy();    

        }
        public List<ProductViewModel> GetProducts()
        {
            var productViewModel = new List<ProductViewModel>();
            var mydata = productRepositroy.GetProducts();

            
            //auto mapper is 
            IList<ProductViewModel> data = Mapper.Map<IList<DomainEntity.Product>, IList<ProductViewModel>>(mydata);

            return productViewModel;

        }
    }
}
