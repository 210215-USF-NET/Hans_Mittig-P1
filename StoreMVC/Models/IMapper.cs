using StoreModels;

namespace StoreMVC.Models
{
    public interface IMapper
    {
        Customer cast2Customer(CustomerCRVM newCustomer);
        CustomerIndexVM cast2CustomerIndexVM(Customer customer);
    }
}