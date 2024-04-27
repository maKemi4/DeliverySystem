using DeliverySystem.BusinessLogic.Services.Abstractions;
using DeliverySystem.Infrastructure.DistanceAndTimeFinding.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services
{
    public class OptimalPathFindingService : IOptimalPathFindingService
    {
        public Task<IEnumerable<string>> FindPath()
        {
            return Task.FromResult<IEnumerable<string>>(Array.Empty<string>());
        }
    }
}
//TODO: Реалізувати алгоритм вирішення задачі Комівояжера