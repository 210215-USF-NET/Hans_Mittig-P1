using System;
namespace StoreModels
{
    public class Orders
    {
        public int id { get; set; }

        public decimal total { get; set; }

        public DateTime orderdate { get; set; }

        public int? customerid { get; set; }
        // Customer should be data type

        public int? locationid { get; set; }

        public override string ToString() => $"Total: ${this.total} Date: {this.orderdate}";

    }
}