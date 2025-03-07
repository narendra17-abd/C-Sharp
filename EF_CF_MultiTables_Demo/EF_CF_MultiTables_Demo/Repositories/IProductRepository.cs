using EF_CF_MultiTables_Demo.Model;

namespace EF_CF_MultiTables_Demo.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<IEnumerable<Product>> SearchProducts(string keyword);
    }
}
