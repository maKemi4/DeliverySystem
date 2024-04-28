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
    public class OrderExecutorService : IOrderExecutorService
    {
        private readonly IOrderExecutorRepository _orderExecutorRepository;
        private readonly IMapper _mapper;

        public OrderExecutorService(IOrderExecutorRepository orderExecutorRepository, IMapper mapper)
        {
            _orderExecutorRepository = orderExecutorRepository;
            _mapper = mapper;
        }

        public async Task<int> AddOrderExecutor(OrderExecutor orderExecutor)
        {
            var orderExecutorId = await _orderExecutorRepository.AddOrderExecutor(orderExecutor);
            return orderExecutorId;
        }

        public async Task<OrderExecutorInfo> GetOrderExecutor(int orderExecutorId)
        {
            var record = await _orderExecutorRepository.GetOrderExecutor(orderExecutorId);
            var item = _mapper.Map<OrderExecutorInfo>(record);

            return item;
        }
    }
}
