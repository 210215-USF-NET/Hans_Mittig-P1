using System;
using System.Collections.Generic;
using StoreDL;
//using Entity = StoreDL.Entities;
using StoreModels;

namespace StoreBL
{
    public class StrBL : IStrBL
    {
        private IStoreRepository _repo;
        public StrBL(IStoreRepository repo)
        {
            _repo = repo;
        }
        public void AddCustomer(Customer newCustomer)
        {
            _repo.AddCustomer(newCustomer);
        }

        public List<Customer> GetCustomers()
        {
            return _repo.GetCustomers();
        }

        public Customer GetCustomerName(string name)
        {
            return _repo.GetCustomerName(name);
        }

        public Customer GetCustomerPassword(string password)
        {
            return _repo.GetCustomerPassword(password);
        }

        public List<Location> ViewLoc()
        {
            return _repo.ViewLoc();
        }

        public Location ChooseLoc(string location)
        {
            return _repo.ChooseLoc(location);
        }

        public Location ChooseLocById(int id)
        {
            return _repo.ChooseLocById(id);
        }


        public void ViewInventory(string locvalue)
        {
            _repo.ViewInventory(locvalue);
        }

        public Inventory InventorySelect(string inventory)
        {
            return _repo.SelectInventory(inventory);
        }

        public List<Product> ViewProducts()
        {
            return _repo.ViewProducts();
        }

        public Product SelectProduct(int x)
        {
            return _repo.SelectProduct(x);
        }
        public Orders AddOrder(Orders order)
        {
            return _repo.AddOrder(order);
        }

        public void AddOrderToDatabase(Orders order)
        {
            _repo.AddOrderToDatabase(order);
        }
        public Manager ManagerSignInName(string name)
        {
            return _repo.ManagerSignInName(name);
        }

        public Manager ManagerSignInPassword(string password)
        {
            return _repo.ManagerSignInPassword(password);
        }

        public List<Orders> AllOrders()
        {
            return _repo.AllOrders();
        }

        public List<Orders> GetOrdersByCustID(int x)
        {
            return _repo.GetOrdersByCustID(x);
        }

        public List<Orders> GetOrdersByLocID(int x)
        {
            return _repo.GetOrdersByLocID(x);
        }
        public List<OrderItems> AllOrderItems()
        {
            return _repo.AllOrderItems();
        }
        public List<Product> GetProductByLocID(int x)
        {
            return _repo.GetProductByLocID(x);
        }

        public Orders GetOrder(int x)
        {
            return _repo.GetOrder(x);
        }

        public List<OrderItems> GetOrderByOrderID(int x)
        {
            return _repo.GetOrderByOrderID(x);
        }


        public void AddOrderItems(OrderItems oitems)
        {
             _repo.AddOrderItems(oitems);
        }

        public void AddOrderItemsToDatabase(OrderItems order)
        {
            _repo.AddOrderItemsToDatabase(order);
        }
        public Product UpdateInventory(Product inv1)
        { 
            return _repo.UpdateInventory(inv1);
        }

        public Inventory GetInventoryById(int prodId, int locId)
        {
            return _repo.GetInventoryById(prodId,locId);
        }
    }
}
