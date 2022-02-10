using CandyStore.Application.Product;
using CandyStore.Core.Communication.Mediator;
using CandyStore.Core.Messages.CommonMessages.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CandyStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductController : CandyStoreControllerBase
    {
        private readonly IProductAppService productService;

        public ProductController(IProductAppService productService, 
                                 INotificationHandler<DomainNotification> notifications,
                                 IMediatorHandler mediatorHandler) : 
                                 base(notifications, mediatorHandler)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> Get()
        {
            var listProducts = productService.GetAllProducts();

            return Ok(listProducts);
        }
    }
}
