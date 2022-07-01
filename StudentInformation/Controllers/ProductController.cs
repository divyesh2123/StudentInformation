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
        public List<ProductViewModel> getAllProduct(int productID)
        {
            return producrService.GetProducts();
        }

        [Route("addProduct")]
        [HttpPost]
        public bool addProductInfo([FromBody] ProductViewModel productViewModel)
        {


            return producrService.AddProduct(productViewModel);
        }

        [Route("deleteProduct")]
        [HttpDelete]
        public bool deleteProductInfo(int productId)
        {

            return producrService.DeleteProduct(productId);
        }

        [Route("updateProductInfo")]
        [HttpPut]
        public bool UpdateProductInfo([FromBody]ProductViewModel productViewModel, [FromUri] int productId)
        {

            return producrService.UpdateProduct(productViewModel, productId);
        }



    }
}
