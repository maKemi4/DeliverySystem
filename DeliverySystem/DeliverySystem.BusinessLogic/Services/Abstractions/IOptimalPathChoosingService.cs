using DeliverySystem.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services.Abstractions
{
    public interface IOptimalPathChoosingService
    {
        PathResult ChooseBestOne(IEnumerable<int> vertices,
           double[,] matrix,
           IEnumerable<decimal> importanceRates);
    }
}
