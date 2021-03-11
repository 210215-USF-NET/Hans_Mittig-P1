using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    public class ManagerIndexVM
    {
        private String managerName;
        private String managerPassword;

        public int Customerid { get; set; }
        [DisplayName("Customer Name")]
        public String ManagerName { get; set; }
        public String ManagerPassword { get; set; }
    }
}
