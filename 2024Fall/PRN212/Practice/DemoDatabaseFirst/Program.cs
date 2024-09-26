using DemoDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStoreContext storeContext = new MyStoreContext();

            var products = from p in storeContext.Products
                           select new { p.ProductName, p.CategoryId };
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name :{product.ProductName},categoryID:{product.CategoryId}");
            }
            Console.WriteLine("---------------");

            IQueryable<Category>cats = storeContext.Categories.Include(c => c.Products);
            Console.WriteLine(cats);
            Console.WriteLine("---------------");
            foreach (Category c in cats)
            {
                Console.WriteLine($"CategoryId:{c.CategoryId} has {c.Products.Count} products");
            }
        }
    }
}
