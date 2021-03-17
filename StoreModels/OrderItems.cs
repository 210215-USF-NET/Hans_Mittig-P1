using System;
namespace StoreModels
{
    public class OrderItems
    {
        public int id { get; set; }
        public int? orderid { get; set; }
        public int quantity { get; set; }
        public int? productid { get; set; }

        public override string ToString() => $"Product: {this.id} Quantity: {this.quantity}";
    }
}