using DeliverySystem.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services
{
    public interface IOptimalPathChoosingService
    {
        PathResult ChooseBestOne(IEnumerable<int> vertices,
           double[,] matrix,
           IEnumerable<decimal> importanceRates);
    }

    public class OptimalPathChoosingService : IOptimalPathChoosingService
    {
        public PathResult ChooseBestOne(IEnumerable<int> vertices,
            double[,] matrix,
            IEnumerable<decimal> importanceRates)
        {
            var service = new OptimalPathFindingService();

            PathResult resultByTime = service.FindFinalPath(vertices, matrix, importanceRates, false);
            PathResult resultByImportanceRate = service.FindFinalPath(vertices, matrix, importanceRates, true);

            IEnumerable<int> shortestPathByTime = resultByTime.ShortestPath; 
            double costByTime = resultByTime.TimeCost;
            double importanceRateByTime = resultByTime.ImportanceRateCost;

            IEnumerable<int> shortestPathByImptRate = resultByImportanceRate.ShortestPath; 
            double costByImportanceRate = resultByImportanceRate.TimeCost;
            double importanceRateByImptRate = resultByImportanceRate.ImportanceRateCost;

            double pairwiseСomparisonTimeCosts = ((costByImportanceRate - costByTime) / (costByImportanceRate + costByTime));
            double pairwiseСomparisonImortanceRates = ((importanceRateByTime  - importanceRateByImptRate) / (importanceRateByTime + importanceRateByImptRate));

            if (((pairwiseСomparisonTimeCosts / pairwiseСomparisonImortanceRates) * 100) < 30)
            {
                return new PathResult(shortestPathByTime, costByTime, importanceRateByTime);
            }
            else
            {
                return new PathResult(shortestPathByImptRate, costByImportanceRate, importanceRateByImptRate);
            }
        }
    }
}
