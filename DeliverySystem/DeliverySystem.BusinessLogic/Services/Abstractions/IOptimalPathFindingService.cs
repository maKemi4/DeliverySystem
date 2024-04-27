using DeliverySystem.Infrastructure.DistanceAndTimeFinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services.Abstractions
{
    public interface IOptimalPathFindingService
    {
        Task<IEnumerable<string>> FindPath();
    }
}
