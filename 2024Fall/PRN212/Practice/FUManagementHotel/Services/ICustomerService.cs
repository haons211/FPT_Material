using BusinessObjects;

namespace Services;

public interface ICustomerService
{
    void AddCustomer(Customer customer);
    void UpdateCustomer(Customer customer);
    void DeleteCustomer(int customerId);
    Customer GetCustomer(int customerId);
    List<Customer> GetCustomers();
    List<Customer> GetCustomersByNames(string customerFullName);
}