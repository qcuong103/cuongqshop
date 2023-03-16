using CuongqShop.Data.infrastructure;
using CuonqShop.Model.Models;

namespace CuongqShop.Data.Repositories
{
    public interface IProductRepository
    {
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory) 
        {
        }
    }
}
