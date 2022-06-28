using StudentInformation.BussinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation.Service.Interface
{
    internal interface IProducrService
    {
        List<ProductViewModel> GetProducts();
    }
}
