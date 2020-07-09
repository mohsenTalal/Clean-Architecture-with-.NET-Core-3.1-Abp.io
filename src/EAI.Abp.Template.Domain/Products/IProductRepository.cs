using System.Threading.Tasks;

namespace $safeprojectname$.Products
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product);

        Task<Product> GetAsync(int id);

        Task<Product> UpdateAsync(Product product);
    }
}