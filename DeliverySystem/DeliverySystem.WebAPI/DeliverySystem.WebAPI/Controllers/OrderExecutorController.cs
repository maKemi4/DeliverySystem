using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using DeliverySystem.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeliverySystem.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderExecutorController : ControllerBase
    {
        private readonly IOrderExecutorService _orderExecutorService;

        public OrderExecutorController(IOrderExecutorService orderExecutorService)
        {
            _orderExecutorService = orderExecutorService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddOrderExecutor(OrderExecutor orderExecutor)
        {
            var orderExecutorId = await _orderExecutorService.AddOrderExecutor(orderExecutor);
            return Ok(orderExecutorId);
        }

        [HttpGet("{orderExecutorId}")]
        public async Task<ActionResult<OrderExecutorInfo>> GetOrderExecutor(int orderExecutorId)
        {
            var item = await _orderExecutorService.GetOrderExecutor(orderExecutorId);
            return Ok(item);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderExecutorInfo>>> GetOrderExecutors()
        {
            var items = await _orderExecutorService.GetOrderExecutors();
            return Ok(items);
        }
    }
}
