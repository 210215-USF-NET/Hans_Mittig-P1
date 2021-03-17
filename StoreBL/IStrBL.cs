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

         Customer GetCustomerPassword(string password);

         List<Location> ViewLoc();

        Location ChooseLoc(string location);

        public Location ChooseLocById(int id);

        Manager ManagerSignInName(string name);

         Manager ManagerSignInPassword(string password);

         void ViewInventory(string locvalue);

         Inventory InventorySelect(string inventory);

         public List<Product> ViewProducts();

         Product SelectProduct(int x);
        Orders AddOrder(Orders order);

        public void AddOrderItems(OrderItems oitems);

         List<Orders> AllOrders();

        List<Orders> GetOrdersByCustID(int x);

        public List<Orders> GetOrdersByLocID(int x);

         public List<OrderItems> AllOrderItems();

         public List<Product> GetProductByLocID(int x);

         public Orders GetOrder(int x);

         public List<OrderItems> GetOrderByOrderID(int x);

         public Product UpdateInventory(Product inv1);

         public Inventory GetInventoryById(int prodId, int locId);
    }
}