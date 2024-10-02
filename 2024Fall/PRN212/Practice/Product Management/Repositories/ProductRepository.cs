using BusinessObjects;
using System.Collections.Generic;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        // Lưu sản phẩm mới
        public void SaveProduct(Product p)
        {
            ProductDAO.SaveProduct(p);
        }

        // Xóa sản phẩm
        public void DeleteProduct(Product p)
        {
            ProductDAO.DeleteProduct(p);
        }

        // Cập nhật sản phẩm
        public void UpdateProduct(Product p)
        {
            ProductDAO.UpdateProduct(p);
        }

        // Lấy danh sách tất cả sản phẩm
        public List<Product> GetProducts()
        {
            return ProductDAO.GetProducts();
        }

        // Lấy sản phẩm theo ID
        public Product GetProductById(int id)
        {
            return ProductDAO.GetProductById(id);
        }
    }
}
