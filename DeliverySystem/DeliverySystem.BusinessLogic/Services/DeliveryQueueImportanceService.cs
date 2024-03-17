using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services
{
    internal class DeliveryQueueImportanceService : IDeliveryQueueImportanceService
    {
        public Task<decimal> Calculate(Requirements requirements)
        {
            //TODO: Порахувати важливості
            return Task.FromResult(2.2m);
        }
    }
}
