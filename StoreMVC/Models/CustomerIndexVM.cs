using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    [Serializable]
    public class CustomerIndexVM
    {
        public int id { get; set; }
        [DisplayName("Customer Name")]
        [Required]
        public String customerName { get; set; }
        [DisplayName("Password")]
        [Required]
        public String customerPassword { get; set; }
    }
}
