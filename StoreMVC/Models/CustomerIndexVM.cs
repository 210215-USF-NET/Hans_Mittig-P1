using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    [Serializable]
    public class CustomerIndexVM
    {
        //public int customerid;
        public String customerName;
        public String customerPassword;
        public int Id { get; set; }
        [DisplayName("Manager Name")]
        public String CustomerName { get; set; }
        public String CustomerPassword { get; set; }
    }
}
