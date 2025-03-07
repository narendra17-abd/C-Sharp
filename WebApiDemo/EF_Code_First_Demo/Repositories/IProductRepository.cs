using EF_Code_First_Demo.Model;

namespace EF_Code_First_Demo.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Products>> GetProductsAsync();
        Task<Products> GetProductByIdAsync(int id);
        Task<Products> AddProductAsync(Products product);
        Task<Products> UpdateProductAsync(int id, Products product);
        Task<string> DeleteProductAsync(int id);
    }
}
