using Repo_Pattern.Model;

namespace Repo_Pattern.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<Product> AddProductAsync(Product product);

        Task<Product> UpdateProductAsync(int id, Product product);

        Task<string> DeleteProductAsync(int id);
    }
}
