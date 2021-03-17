using StoreModels;

namespace StoreMVC.Models
{
    public interface IMapper
    {
        Customer cast2Customer(CustomerCRVM newCustomer);
        CustomerIndexVM cast2CustomerIndexVM(Customer customer);

        CustomerCRVM cast2CustomerCRVM(Customer customer);

        Product cast2Product(ProductVM product);

        ProductVM cast2ProductVM(Product product);

        public ManagerIndexVM cast2ManagerIndexVM(Manager manager);

        public Manager cast2Manager(ManagerIndexVM manager);

        public Orders ParseOrders(OrderCRVM order);

        public OrderCRVM ParseOrders(Orders order);
    }
}