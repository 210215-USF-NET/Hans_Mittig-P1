using System;
namespace StoreModels
{
    public class Location
    {
        public int id { get; set; }
        public string locationName { get; set; }

        public override string ToString() => $"{this.locationName.ToString()}";
    }
}