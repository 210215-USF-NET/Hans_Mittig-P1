﻿using StoreModels;
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
                customerName = customer.CustomerName,
                customerPassword = customer.CustomerPassword
            };
        }
        public Customer cast2Customer(CustomerCRVM newCustomer)
        {
            return new Customer
            {
                CustomerName = newCustomer.CustomerName,
                CustomerPassword = newCustomer.CustomerPassword
            };
        }

        public CustomerCRVM cast2CustomerCRVM(Customer customer)
        {
            return new CustomerCRVM
            {
                CustomerName = customer.CustomerName,
                CustomerPassword = customer.CustomerPassword
            };
        }

        public ManagerIndexVM cast2ManagerIndexVM(Manager manager)
        {
            return new ManagerIndexVM
            {
                ManagerName = manager.ManagerName,
                ManagerPassword = manager.ManagerPassword
            };
        }

        public Manager cast2Manager(ManagerIndexVM manager)
        {
            return new Manager
            {
                ManagerName = manager.ManagerName,
                ManagerPassword = manager.ManagerPassword
            };
        }

        public Orders ParseOrders(OrderCRVM order)
        {
            return new Orders
            {
                id = order.Id,
                Total = order.Total,
                Orderdate = order.orderdate,
                customerid = order.Customerid,
                locationid = order.Locationid
            };
        }

        public OrderCRVM ParseOrders(Orders order)
        {
            return new OrderCRVM
            {
                Total = order.Total,
                orderdate = order.Orderdate,
                Customerid = order.Customerid.Value,
                Locationid = order.Locationid.Value
            };
        }
    }
}
