using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    public class StoreRepoDB : IStoreRepository
    {
        private readonly StoreDBContext _context;
        public StoreRepoDB(StoreDBContext context)
        {
            _context = context;
        }
        public Customer AddCustomer(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return newCustomer;
        }

        public void AddOrder(decimal x, DateTime y, Customer c, Location l)
        {
            throw new NotImplementedException();
        }

        public void AddOrderItems(Orders x, int y, Product p)
        {
            throw new NotImplementedException();
        }

        public void AddOrderItemsToDatabase(OrderItems order)
        {
            throw new NotImplementedException();
        }

        public void AddOrderToDatabase(Orders order)
        {
            throw new NotImplementedException();
        }

        public List<OrderItems> AllOrderItems()
        {
            throw new NotImplementedException();
        }

        public List<Orders> AllOrders()
        {
            throw new NotImplementedException();
        }

        public Location ChooseLoc(string location)
        {
            throw new NotImplementedException();
        }

        public Customer CustomerSignIn(string password)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerName(string name)
        {
            return _context.Customers.FirstOrDefault(customer => customer.CustomerName == name);
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.Select(customer => customer).ToList();
        }

        public Inventory GetInventoryById(int prodId, int locId)
        {
            throw new NotImplementedException();
        }

        public Orders GetOrder(int x)
        {
            throw new NotImplementedException();
        }

        public List<OrderItems> GetOrderByOrderID(int x)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int x)
        {
            throw new NotImplementedException();
        }

        public Manager ManagerSignInName(string name)
        {
            throw new NotImplementedException();
        }

        public Manager ManagerSignInPassword(string password)
        {
            throw new NotImplementedException();
        }

        public Inventory SelectInventory(string inventory)
        {
            throw new NotImplementedException();
        }

        public Product SelectProduct(string product)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventory(Inventory inv1)
        {
            throw new NotImplementedException();
        }

        public void ViewInventory(string locvalue)
        {
            throw new NotImplementedException();
        }

        public List<Location> ViewLoc()
        {
            throw new NotImplementedException();
        }

        public void ViewProducts(string invvalue, string locvalue)
        {
            throw new NotImplementedException();
        }
    }
}
