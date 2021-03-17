using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    [Serializable]
    public class ManagerIndexVM
    {
        public String managerName;
        public String managerPassword;

        public int Id { get; set; }
        [DisplayName("Manager Name")]
        [Required]
        public String ManagerName { get; set; }
        [DisplayName("Manager Password")]
        [Required]
        public String ManagerPassword { get; set; }
    }
}
