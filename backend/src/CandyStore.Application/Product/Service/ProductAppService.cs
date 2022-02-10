using AutoMapper;
using CandyStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyStore.Application.Product
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper; 

        public ProductAppService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            var listProduct = productRepository.Get();

            return mapper.Map<IEnumerable<ProductDto>>(listProduct.ToList());
        }
    }
}
