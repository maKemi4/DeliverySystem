using AutoMapper;
using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using DeliverySystem.Infrastructure.Models;
using DeliverySystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IDeliveryQueueRepository _deliveryQueueRepository;

        public OrderItemService(IOrderRepository orderRepository, 
            IMapper mapper, 
            IDeliveryQueueRepository deliveryQueueRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _deliveryQueueRepository = deliveryQueueRepository;
        }

        public async Task<int> CreateOrder(string executorName, string executorSurname, string organizationName)
        {
            var records = await _deliveryQueueRepository.GetAll(true);
            var selectedOrders = records.OrderByDescending(i => i.ImportanceRate).Take(5); //MB TODO
            var selecetedIds = selectedOrders.Select(item => item.DeliveryQueueId);

            var orderId = await _orderRepository.CreateOrder(selecetedIds, executorName, executorSurname, organizationName);

            return orderId;
        }

        public async Task<IEnumerable<OrderItem>> GetOrderItems(int orderId)
        {
            var records = await _orderRepository.GetOrderItems(orderId);
            var items = _mapper.Map<IEnumerable<OrderItem>>(records);

            return items;
        }
    }
}