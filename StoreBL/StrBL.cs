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


        public void ViewInventory(string locvalue)
        {
            _repo.ViewInventory(locvalue);
        }

        public Inventory InventorySelect(string inventory)
        {
            return _repo.SelectInventory(inventory);
        }

        public void ViewProducts(string invvalue, string locvalue)
        {
            _repo.ViewProducts(invvalue, locvalue);
        }

        public Product SelectProduct(string product)
        {
            return _repo.SelectProduct(product);
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

        public List<OrderItems> AllOrderItems()
        {
            return _repo.AllOrderItems();
        }
        public Product GetProduct(int x)
        {
            return _repo.GetProduct(x);
        }

        public Orders GetOrder(int x)
        {
            return _repo.GetOrder(x);
        }

        public List<OrderItems> GetOrderByOrderID(int x)
        {
            return _repo.GetOrderByOrderID(x);
        }


        public void AddOrderItems(Orders x, int y, Product p)
        {
             _repo.AddOrderItems(x, y, p);
        }

        public void AddOrderItemsToDatabase(OrderItems order)
        {
            _repo.AddOrderItemsToDatabase(order);
        }
        public void UpdateInventory(Inventory inv1, Inventory inv2)
        {
            inv1.Quantity = inv2.Quantity;
            
            _repo.UpdateInventory(inv1);
        }

        public Inventory GetInventoryById(int prodId, int locId)
        {
            return _repo.GetInventoryById(prodId,locId);
        }
    }
}
