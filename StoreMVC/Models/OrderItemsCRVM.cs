using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    public class OrderItemsCRVM
    {
        public int id { get; set; }
        public int? orderid { get; set; }
        public int quantity { get; set; }
        public int? productid { get; set; }
    }
}
