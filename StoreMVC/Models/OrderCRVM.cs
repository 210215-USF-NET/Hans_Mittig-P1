using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    [Serializable]
    public class OrderCRVM
    {
        public int id;
        public decimal total;
        public DateTime orderdate;
        public int customerid;
        public int locationid;

        [DisplayName("Order ID")]
        public int Id { get; set; }
        [DisplayName("Total Price")]
        public decimal Total { get; set; }
        public int Customerid { get; set; }
        [DisplayName("Location")]
        public int Locationid { get; set; }
    }
}
