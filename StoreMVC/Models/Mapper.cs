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
    }
}
