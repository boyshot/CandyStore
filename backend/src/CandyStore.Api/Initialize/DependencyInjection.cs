using CandyStore.Application.Product;
using CandyStore.Core.Communication.Mediator;
using CandyStore.Core.Messages.CommonMessages.Notifications;
using CandyStore.Data;
using CandyStore.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyStore.Api.Initialize
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Mediator
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // Notifications
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // Context CandyStore
            services.AddScoped<ApplicationContext>();

            // Services
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductAppService, ProductAppService>();
        }

        public static void RegisterServicesAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ProductProfile));
        }
    }
}
