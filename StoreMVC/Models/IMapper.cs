using StoreModels;

namespace StoreMVC.Models
{
    public interface IMapper
    {
        Customer cast2Customer(CustomerCRVM newCustomer);
        CustomerIndexVM cast2CustomerIndexVM(Customer customer);

        CustomerCRVM cast2CustomerCRVM(Customer customer);

        public ManagerIndexVM cast2ManagerIndexVM(Manager manager);

        public Manager cast2Manager(ManagerIndexVM manager);
    }
}