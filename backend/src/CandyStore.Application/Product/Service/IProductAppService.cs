using System.Collections.Generic;

namespace CandyStore.Application.Product
{
    public interface IProductAppService 
    {
        IEnumerable<ProductDto> GetAllProducts();
    }
}
