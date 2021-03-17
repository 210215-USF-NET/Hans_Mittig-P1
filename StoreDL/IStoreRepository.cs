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

        Location ChooseLocById(int id);

        void ViewInventory(string locvalue);

         Inventory SelectInventory(string inventory);

         public List<Product> ViewProducts();

         Product SelectProduct(int x);

         Orders AddOrder(Orders order);

         public void AddOrderToDatabase(Orders order);

         List<Orders> AllOrders();

         public List<OrderItems> AllOrderItems();

         public Manager ManagerSignInName(string name);
         public Manager ManagerSignInPassword(string password);
         public List<Product> GetProductByLocID(int x);
         public Orders GetOrder(int x);
         public OrderItems AddOrderItems(OrderItems oitems);

        public List<Orders> GetOrdersByCustID(int x);

        public List<Orders> GetOrdersByLocID(int x);

         public void AddOrderItemsToDatabase(OrderItems order);

        public Product UpdateInventory(Product inv1);

         public Inventory GetInventoryById(int prodId, int locId);
    }
}