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

        public Orders AddOrder(Orders order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public OrderItems AddOrderItems(OrderItems oitems)
        {
            _context.OrderItems.Add(oitems);
            _context.SaveChanges();
            return oitems;
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
            return _context.Orders.Select(order => order).ToList();
        }

        public Location ChooseLoc(string location)
        {
            return _context.Locations.FirstOrDefault(locationn => locationn.locationName == location);
        }

        public Location ChooseLocById(int id)
        {
            return _context.Locations.FirstOrDefault(locationn => locationn.id == id);
        }
        public Customer GetCustomerPassword(string password)
        {
            return _context.Customers.FirstOrDefault(customer => customer.customerPassword == password);
        }

        public Customer GetCustomerName(string name)
        {
            return _context.Customers.FirstOrDefault(customer => customer.customerName == name);
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

        public List<Orders> GetOrdersByCustID(int x)
        {
            List <Orders> ordlist = AllOrders();
            return ordlist.Select(O => O).Where(O => O.customerid == x).ToList();
        }

        public List<Orders> GetOrdersByLocID(int x)
        {
            List<Orders> ordlist = AllOrders();
            return ordlist.Select(O => O).Where(O => O.locationid == x).ToList();
        }

        public List<OrderItems> GetOrderByOrderID(int x)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByLocID(int x)
        {
            List<Product> prodlist = ViewProducts();
             return  prodlist.Select(O => O).Where(O => O.locationid == x).ToList();
        }

        public Manager ManagerSignInName(string name)
        {
            return _context.Managers.FirstOrDefault(manager => manager.managerName == name);
        }

        public Manager ManagerSignInPassword(string password)
        {
            return _context.Managers.FirstOrDefault(manager => manager.managerPassword == password);
        }

        public Inventory SelectInventory(string inventory)
        {
            throw new NotImplementedException();
        }

        public Product SelectProduct(int x)
        {
            return _context.Products.FirstOrDefault(product => product.id == x);
        }

        public Product UpdateInventory(Product inv1)
        {
            Product oldinv = _context.Products.Find(inv1.id);
            _context.Entry(oldinv).CurrentValues.SetValues(inv1);
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
            return inv1;
        }

        public void ViewInventory(string locvalue)
        {
            throw new NotImplementedException();
        }

        public List<Location> ViewLoc()
        {
            return _context.Locations.Select(location => location).ToList();
        }

        public List<Product> ViewProducts()
        {
            return _context.Products.Select(customer => customer).ToList();
        }
    }
}
