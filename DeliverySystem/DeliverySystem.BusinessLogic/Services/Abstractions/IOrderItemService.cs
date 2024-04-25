using DeliverySystem.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services.Abstractions
{
    public interface IOrderItemService
    {
        Task<int> CreateOrder(string executorName, string executorSurname, string organizationName);
        Task<IEnumerable<OrderItem>> GetOrderItems(int orderId);
    }
}
