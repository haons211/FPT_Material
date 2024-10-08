namespace DataAccessLayer;
using BusinessObjects;

public class CustomerDAO
{
    public static void AddCustomer(Customer customer)
    {
        using var context = new FuminiHotelManagementContext();
        context.Customers.Add(customer);
        context.SaveChanges();
    }

    // Update an existing customer in the database
    public static void UpdateCustomer(Customer customer)
    {
        using var context = new FuminiHotelManagementContext();
        context.Customers.Update(customer);
        context.SaveChanges();
    }

    // Delete a customer by ID
    public static void DeleteCustomer(int customerId)
    {
        using var context = new FuminiHotelManagementContext();
        var customer = context.Customers.Find(customerId);
        if (customer != null)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }
    }

    // Get a customer by ID
    public static Customer GetCustomer(int customerId)
    {
        using var context = new FuminiHotelManagementContext();
        return context.Customers.Find(customerId);
    }

    // Get all customers
    public static List<Customer> GetCustomers()
    {
        using var context = new FuminiHotelManagementContext();
        return context.Customers.ToList();
    }

    // Get customers by their full name
    public static List<Customer> GetCustomersByNames(string customerFullName)
    {
        using var context = new FuminiHotelManagementContext();
        return context.Customers
            .Where(c => c.CustomerFullName.Contains(customerFullName))
            .ToList();
    }
}