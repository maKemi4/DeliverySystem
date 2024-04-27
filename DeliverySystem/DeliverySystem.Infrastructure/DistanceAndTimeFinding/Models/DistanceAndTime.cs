using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.DistanceAndTimeFinding.Models
{
    public record DistanceAndTime(double DistanceBetweenPoints, 
                                  double TimeBetweenPoints,
                                  string LocalityNames);
}
