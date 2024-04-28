using DeliverySystem.BusinessLogic.Services;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using DeliverySystem.Infrastructure.DistanceAndTimeFinding;
using DeliverySystem.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic
{
    public static class Extensions
    {
        public static IServiceCollection AddDeliveryServices(this IServiceCollection services)
        {
            services.AddTransient<IDeliveryQueueService, DeliveryQueueService>();
            services.AddTransient<IDeliveryQueueRepository, DeliveryQueueRepository>();
            services.AddTransient<IOrderExecutorRepository, OrderExecutorRepository>();
            services.AddTransient<IDeliveryQueueImportanceService, DeliveryQueueImportanceService>();
            services.AddTransient<IOrderItemService, OrderItemService>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOptimalPathFindingService, OptimalPathFindingService>();
            services.AddTransient<IDistanceAndTimeFindingService, DistanceAndTimeFindingService>();
            services.AddTransient<IOrderExecutorService, OrderExecutorService>();

            services.AddAutoMapper(typeof(DeliveryQueueService));

            return services;

            // Реєструємо сервіс
        }
    }
}
