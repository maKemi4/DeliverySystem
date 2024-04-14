using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using DeliverySystem.WebAPI.Models;
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
        public IActionResult AddRequest(AddDeliveryRequestModel deliveryRequest)
        {
            var request = new DeliveryRequest() { };



            return Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<DeliveryQueueItem>> GetAll()
        {
            var items = await _deliveryQueueService.GetRequests();
            return items;
        }
    }
}
