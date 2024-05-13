using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.Infrastructure.DistanceAndTimeFinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeliverySystem.BusinessLogic.Services.OptimalPathFindingService;

namespace DeliverySystem.BusinessLogic.Services.Abstractions
{
    public interface IOptimalPathFindingService
    {
        PathResult FindFinalPath(IEnumerable<int> vertices, 
            double[,] adjacencyMatrix, 
            IEnumerable<decimal> importanceRates,
            bool minImportanceRate);
    }
}
