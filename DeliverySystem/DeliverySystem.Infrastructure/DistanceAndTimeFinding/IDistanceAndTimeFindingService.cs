using DeliverySystem.Infrastructure.DistanceAndTimeFinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.DistanceAndTimeFinding
{
    public interface IDistanceAndTimeFindingService
    {
        Task<DistanceAndTime> CalculateDistanceAndTime(Locality firstLocality, Locality secondLocality);
    }
}
