using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using DeliverySystem.Infrastructure.DistanceAndTimeFinding;
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
        public PathResult FindFinalPath(IEnumerable<int> vertices,
            double[,] adjacencyMatrix, 
            IEnumerable<decimal> importanceRates,
            bool minImportanceRate)
        {
            OptimalPathFindingLogic tspSolverFirst = new OptimalPathFindingLogic(vertices, adjacencyMatrix, importanceRates.ToList(), minImportanceRate);

            double timeCost;
            double importanceRateCost;
            IEnumerable<int> shortestPath = tspSolverFirst.Solve(out timeCost, out importanceRateCost);

            return new PathResult(shortestPath, timeCost, importanceRateCost);
        }
    }
}
