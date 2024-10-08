namespace Repositories;
using BusinessObjects;
public interface ICustomerRepository
{
    void AddCustomer(Customer customer);
    void UpdateCustomer(Customer customer);
    void DeleteCustomer(int customerId);
    Customer GetCustomer(int customerId);
    List<Customer> GetCustomers();
    List<Customer> GetCustomersByNames(string customerFullName);
}