using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    public class Mapper : IMapper
    {
        public CustomerIndexVM cast2CustomerIndexVM(Customer customer)
        {
            return new CustomerIndexVM
            {
                //customerid = customer.customerid,
                customerName = customer.customerName,
                customerPassword = customer.customerPassword
            };
        }
        public Customer cast2Customer(CustomerCRVM newCustomer)
        {
            return new Customer
            {
                customerName = newCustomer.CustomerName,
                customerPassword = newCustomer.CustomerPassword
            };
        }

        public CustomerCRVM cast2CustomerCRVM(Customer customer)
        {
            return new CustomerCRVM
            {
                CustomerName = customer.customerName,
                CustomerPassword = customer.customerPassword
            };
        }

        public ManagerIndexVM cast2ManagerIndexVM(Manager manager)
        {
            return new ManagerIndexVM
            {
                ManagerName = manager.managerName,
                ManagerPassword = manager.managerPassword
            };
        }

        public Manager cast2Manager(ManagerIndexVM manager)
        {
            return new Manager
            {
                managerName = manager.ManagerName,
                managerPassword = manager.ManagerPassword
            };
        }

        public Product cast2Product(ProductVM product)
        {
            return new Product
            {
                id = product.id,
                name = product.name,
                description = product.description,
                price = product.price,
                quantity = product.quantity,
                locationid = product.locationid

            };
        }

        public ProductVM cast2ProductVM(Product product)
        {
            return new ProductVM
            {
                id = product.id,
                name = product.name,
                description = product.description,
                price = product.price,
                quantity = product.quantity,
                locationid = product.locationid
            };
        }
        public Orders ParseOrders(OrderCRVM order)
        {
            return new Orders
            {
                id = order.Id,
                total = order.Total,
                orderdate = order.Orderdate,
                customerid = order.Customerid,
                locationid = order.Locationid
            };
        }

        public OrderCRVM ParseOrders(Orders order)
        {
            return new OrderCRVM
            {
                Id = order.id,
                Total = order.total,
                Orderdate = order.orderdate,
                Customerid = order.customerid.Value,
                Locationid = order.locationid.Value
            };
        }
    }
}
