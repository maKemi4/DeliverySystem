using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public class PathResult
    {
        public IEnumerable<int> ShortestPath { get; }
        public double TimeCost { get; }
        public double ImportanceRateCost { get; }

        public PathResult(IEnumerable<int> shortestPath, double timeCost, double importanceRate)
        {
            ShortestPath = shortestPath;
            TimeCost = timeCost;
            ImportanceRateCost = importanceRate;
        }
    }
}