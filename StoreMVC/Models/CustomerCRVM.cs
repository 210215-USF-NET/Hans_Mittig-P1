using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    [Serializable]
    public class CustomerCRVM
    {
        //public int Customerid { get; set; }
        public int id { get; set; }
        [DisplayName("Customer Name")]
        [Required]
        public String CustomerName { get; set; }
        [DisplayName("Customer Password")]
        [Required]
        public String CustomerPassword { get; set; }

        //[Range(0, Int32.MaxValue, ErrorMessage = "Value should not be negative")]
    }
}
