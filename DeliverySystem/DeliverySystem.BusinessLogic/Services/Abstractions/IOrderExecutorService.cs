using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services.Abstractions
{
    public interface IOrderExecutorService
    {
        Task<int> AddOrderExecutor(OrderExecutor orderExecutor);
        Task<OrderExecutorInfo> GetOrderExecutor(int orderExecutorId);
        Task<IEnumerable<OrderExecutorInfo>> GetOrderExecutors();
    }
}
