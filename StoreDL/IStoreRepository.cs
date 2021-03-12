using StoreModels;
using Model = StoreModels;
using System.Collections.Generic;
using System;
namespace StoreDL
{
    public interface IStoreRepository
    {
         List<Customer> GetCustomers();

         Customer AddCustomer(Customer newCustomer);

         Customer GetCustomerName(string name);

         public List<OrderItems> GetOrderByOrderID(int x);

         Customer GetCustomerPassword(string password);

         List<Location> ViewLoc();

         Location ChooseLoc(string location);

         void ViewInventory(string locvalue);

         Inventory SelectInventory(string inventory);

         void ViewProducts(string invvalue, string locvalue);

         Product SelectProduct(string product);

         Orders AddOrder(Orders order);

         public void AddOrderToDatabase(Orders order);

         List<Orders> AllOrders();

         public List<OrderItems> AllOrderItems();

         public Manager ManagerSignInName(string name);
         public Manager ManagerSignInPassword(string password);
         public Product GetProduct(int x);
         public Orders GetOrder(int x);
         public void AddOrderItems(Orders x, int y, Product p);

         public void AddOrderItemsToDatabase(OrderItems order);

         public void UpdateInventory(Inventory inv1);

         public Inventory GetInventoryById(int prodId, int locId);
    }
}