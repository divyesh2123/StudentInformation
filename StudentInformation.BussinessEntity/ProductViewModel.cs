using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation.BussinessEntity
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }

        [JsonIgnore]
        
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Please enter productName")]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

    }
}
