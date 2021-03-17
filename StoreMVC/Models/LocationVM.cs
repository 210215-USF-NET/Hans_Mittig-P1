using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;

namespace StoreMVC.Models
{
    public class LocationVM
    {
        [DisplayName("Location ID")]
        public int id { get; set; }
        [DisplayName("Location Name")]
        public string locationName { get; set; }

        public IEnumerable<SelectListItem> LocationList { get; set; }

    }
}
