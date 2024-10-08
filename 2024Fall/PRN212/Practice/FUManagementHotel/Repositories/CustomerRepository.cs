using BusinessObjects;
using DataAccessLayer;

namespace Repositories;

public class CustomerRepository : ICustomerRepository
{
 

    // Triển khai các phương thức bằng cách sử dụng CustomerDAO

    public void AddCustomer(Customer customer)
    {
        CustomerDAO.AddCustomer(customer);
    }

    public void UpdateCustomer(Customer customer)
    {
        CustomerDAO.UpdateCustomer(customer);
    }

    public void DeleteCustomer(int customerId)
    {
        CustomerDAO.DeleteCustomer(customerId);
    }

    public Customer GetCustomer(int customerId)
    {
        return CustomerDAO.GetCustomer(customerId);
    }

    public List<Customer> GetCustomers()
    {
        return CustomerDAO.GetCustomers();
    }

    public List<Customer> GetCustomersByNames(string customerFullName)
    {
        return CustomerDAO.GetCustomersByNames(customerFullName);
    }
}