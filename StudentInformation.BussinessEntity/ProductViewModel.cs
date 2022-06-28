using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation.BussinessEntity
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }

        public int CategoryID { get; set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

    }
}
