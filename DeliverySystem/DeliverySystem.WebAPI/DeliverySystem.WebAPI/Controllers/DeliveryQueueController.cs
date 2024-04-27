using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DeliverySystem.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeliveryQueueController : ControllerBase
    {
        private readonly IDeliveryQueueService _deliveryQueueService;

        public DeliveryQueueController(IDeliveryQueueService deliveryQueueService)
        {
            _deliveryQueueService = deliveryQueueService;
        }

        [HttpPost]
        public async Task<IActionResult> AddRequest(DeliveryRequest deliveryRequest)
        {
            await _deliveryQueueService.AddRequest(deliveryRequest);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeliveryQueueItem>>> GetAll()
        {
            var items = await _deliveryQueueService.GetRequests(false);
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryRequestShort>> GetRequestDetailsById(int id)
        {
            var item = await _deliveryQueueService.GetInformation(id);
            return Ok(item);
        }
    }
}
