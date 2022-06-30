using StudentInformation.BussinessEntity;
using StudentInformation.Service.Concreate;
using StudentInformation.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentInformation.Controllers
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        public IProducrService producrService { get; set; }
        public ProductController(IProducrService _producrService)
        {

            producrService = _producrService;
        }

        [Route("getProduct")]
        [HttpGet]
        public List<ProductViewModel> getAllProduct()
        {
            return producrService.GetProducts();
        }



    }
}
