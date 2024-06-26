﻿using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services.Abstractions
{
    public interface IOrderItemService
    {
        Task<int> CreateOrder(int orderExecutorId);
        Task<IEnumerable<OrderItem>> GetOrderItems(int orderId);
    }
}
