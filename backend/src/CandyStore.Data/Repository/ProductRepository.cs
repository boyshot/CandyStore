using CandyStore.Data.Repository;
using CandyStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace CandyStore.Data
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context) { }
    }
}
