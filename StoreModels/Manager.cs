using System;
namespace StoreModels
{
    public class Manager
    {
        public int id { get; set; }
        public String managerName { get; set; }
        public String managerPassword { get; set; }

        public override string ToString() => $"The manager {this.managerName.ToString()} was found in the system.";
    }
}