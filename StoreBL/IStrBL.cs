using StoreModels;
using System.Collections.Generic;
using System;
namespace StoreBL
{
    public interface IStrBL
    {
         List<Customer> GetCustomers();


         void AddCustomer(Customer newCustomer);

         Customer GetCustomerName(string name);

         Customer CustomerSignIn(string password);

         List<Location> ViewLoc();

         Location ChooseLoc(string location);

         Manager ManagerSignInName(string name);

         Manager ManagerSignInPassword(string password);

         void ViewInventory(string locvalue);

         Inventory InventorySelect(string inventory);

         void ViewProducts(string invvalue, string locvalue);

         Product SelectProduct(string product);
        void AddOrder(decimal x, DateTime y, Customer c, Location l);         
        void AddOrderToDatabase(Orders order);

        public void AddOrderItems(Orders x, int y, Product p);

         List<Orders> AllOrders();

         public List<OrderItems> AllOrderItems();

         public Product GetProduct(int x);

         public Orders GetOrder(int x);

         public List<OrderItems> GetOrderByOrderID(int x);

         public void UpdateInventory(Inventory inv1, Inventory inv2);

         public Inventory GetInventoryById(int prodId, int locId);
    }
}