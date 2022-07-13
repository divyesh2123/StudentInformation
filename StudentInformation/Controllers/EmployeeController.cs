using StudentInformation.BussinessEntity;
using StudentInformation.filter;
using StudentInformation.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace StudentInformation.Controllers
{

    [ValidateModelAttribute]
    public class EmployeeController : ApiController
    {
        public IProducrService producrService { get; set; }
        public EmployeeController(IProducrService _producrService)
        {

            producrService = _producrService;
        }
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            var product = producrService.GetProducts();

            IContentNegotiator negotiator = this.Configuration.Services.GetContentNegotiator();

            ContentNegotiationResult result = negotiator.Negotiate(
                typeof(List<ProductViewModel>), this.Request, this.Configuration.Formatters);
            if (result == null)
            {
                var response = new HttpResponseMessage(HttpStatusCode.NotAcceptable);
                throw new HttpResponseException(response);
            }

            return new HttpResponseMessage()
            {
                Content = new ObjectContent<List<ProductViewModel>>(
                    product,                // What we are serializing 
                    result.Formatter,           // The media formatter
                    result.MediaType.MediaType  // The MIME type
                )
            };

         
        }

        // GET api/<controller>/5
        public ProductViewModel Get(int id)
        {
            var data = producrService.GetProducts().Where(pro => pro.ProductID == id).FirstOrDefault();
            return data;
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody] ProductViewModel productViewModel)
        {

            
                producrService.AddProduct(productViewModel);

                return new HttpResponseMessage(HttpStatusCode.OK);
            
            
           
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] ProductViewModel productViewModel)
        {
             producrService.UpdateProduct(productViewModel, id);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            producrService.DeleteProduct(id);
        }
    }
}