using System;
using System.Collections.Generic;
using System.Text;

namespace StoreModels
{
    public class Customer
    {
        public int id { get; set; }
        public String customerName { get; set; }
        public String customerPassword { get; set; }



        public override string ToString() => $"The customer {this.customerName.ToString()} was found in the system.";

    }
}
