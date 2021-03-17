using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    public class ProductVM
    {
        [DisplayName("Product ID")]
        public int id { get; set; }
        [DisplayName("Product")]
        public string name { get; set; }
        [DisplayName("Description")]
        public string description { get; set; }
        [DisplayName("Price")]
        public decimal price { get; set; }
        [DisplayName("Quantity")]
        public int quantity { get; set; }
        [DisplayName("Location")]
        public int locationid { get; set; }
    }
}
