using System;
namespace StoreModels
{
    public class Inventory
    {
        public int id { get; set; }
        public string inventoryname { get; set; }
        public int quantity { get; set; }
        public int? productid { get; set; }
        public int? locationid { get; set; }

        public bool CheckQuantity(int q)
        {
            if(q < 0)
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