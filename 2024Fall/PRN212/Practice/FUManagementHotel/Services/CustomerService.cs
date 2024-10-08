using BusinessObjects;

namespace Services;
using Repositories;
public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    public CustomerService(FuminiHotelManagementContext context)
    {
        _customerRepository = new CustomerRepository();
    }
    
    public void AddCustomer(Customer customer)
    {
        _customerRepository.AddCustomer(customer);
    }

    public void UpdateCustomer(Customer customer)
    {
        _customerRepository.UpdateCustomer(customer);
    }

    public void DeleteCustomer(int customerId)
    {
        _customerRepository.DeleteCustomer(customerId);
    }

    public Customer GetCustomer(int customerId)
    {
        return _customerRepository.GetCustomer(customerId);
    }

    public List<Customer> GetCustomers()
    {
        return _customerRepository.GetCustomers();
    }

    public List<Customer> GetCustomersByNames(string customerFullName)
    {
        return _customerRepository.GetCustomersByNames(customerFullName);
    }
}