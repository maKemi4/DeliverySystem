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
    public class DeliveryQueueService : IDeliveryQueueService
    {
        private readonly IDeliveryQueueRepository _deliveryQueueRepository;
        private readonly IDeliveryQueueImportanceService _queueImportanceService;
        private readonly IMapper _mapper;

        public DeliveryQueueService(IDeliveryQueueRepository deliveryQueueRepository, 
            IDeliveryQueueImportanceService queueImportanceService,
            IMapper mapper)
        {
            _deliveryQueueRepository = deliveryQueueRepository;
            _queueImportanceService = queueImportanceService;
            _mapper = mapper;
        }

        public async Task AddRequest(DeliveryRequest deliveryRequest)
        {
            var importance = await _queueImportanceService.Calculate(deliveryRequest.Requirements);
            var databaseModel = _mapper.Map<DeliveryQueueRecord>(deliveryRequest);

            databaseModel.Importance = importance;

            await _deliveryQueueRepository.Add(databaseModel);
        }


    }
}