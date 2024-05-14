using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using DeliverySystem.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeliverySystem.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderItemService _orderItemService;
        private readonly IPathCreatingService _pathCreatingService;

        public OrderController(IOrderItemService orderItemService,
            IPathCreatingService pathCreatingService)
        {
            _orderItemService = orderItemService;
            _pathCreatingService = pathCreatingService;
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

        [HttpPost("/create-with-path")]
        public async Task<ActionResult<BuiltPath>> CreateOrderAndBuildPath(int orderExecutorId)
        {
            var orderId = await _orderItemService.CreateOrder(orderExecutorId);
            var path = await _pathCreatingService.CreatePath(orderId);

            return Ok(path);
        }

        [HttpGet("{orderId}/path")]
        public async Task<ActionResult<BuiltPath>> GetPath(int orderId)
        {
            var path = await _pathCreatingService.CreatePath(orderId);
            return Ok(path);
        }

    }
}
