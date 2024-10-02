using System;
using System.Collections.Generic;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductService : IProductService // Nếu có interface IProductService
    {
        private readonly IProductRepository iProductRepository;

        public ProductService()
        {
            iProductRepository = new ProductRepository(); // Tạo một thể hiện của ProductRepository
        }

        // Lấy danh sách tất cả sản phẩm
        public List<Product> GetProducts()
        {
            return iProductRepository.GetProducts();
        }

        // Lấy sản phẩm theo ID
        public Product GetProductById(int id)
        {
            return iProductRepository.GetProductById(id);
        }

        // Lưu sản phẩm mới
        public void SaveProduct(Product product)
        {
            iProductRepository.SaveProduct(product);
        }

        // Cập nhật sản phẩm
        public void UpdateProduct(Product product)
        {
            iProductRepository.UpdateProduct(product);
        }

        // Xóa sản phẩm
        public void DeleteProduct(Product product)
        {
            iProductRepository.DeleteProduct(product);
        }
    }
}
