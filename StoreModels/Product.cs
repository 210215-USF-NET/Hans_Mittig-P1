
using System;
namespace StoreModels
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

        public int quantity { get; set; }

        public int locationid { get; set; }

        public bool checkPrice(decimal price)
        {
            if (price < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}