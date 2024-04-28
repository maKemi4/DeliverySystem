using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace DeliverySystem.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderItemService _orderItemService;

        public OrderController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateOrder(int orderExecutorId)
        {
            var orderId = await _orderItemService.CreateOrder(orderExecutorId);
            return Ok(orderId);
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<IEnumerable<OrderItem>>> GetOrderItems(int orderId)
        {
            var items = await _orderItemService.GetOrderItems(orderId);
            return Ok(items);
        }
    }
}
