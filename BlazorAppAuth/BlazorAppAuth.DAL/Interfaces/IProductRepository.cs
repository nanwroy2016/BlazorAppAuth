using BlazorAppAuth.DTO;

namespace BlazorAppAuth.DAL.interfaces
{
    public interface IProductRepository : IRepository<Product, ProductDTO>
    {
    }
    //public interface IProductRepository
    //{
    //    Task<IEnumerable<Product>> GetItems();
    //    Task<IEnumerable<ProductCategory>> GetCategories();
    //    Task<Product> GetItem(int id);
    //    Task<ProductCategory> GetCategory(int id);

    //    Task<IEnumerable<Product>> GetItemsByCategory(int id);

    //}
}
