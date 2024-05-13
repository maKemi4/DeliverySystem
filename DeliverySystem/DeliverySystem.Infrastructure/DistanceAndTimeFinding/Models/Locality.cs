using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.DistanceAndTimeFinding.Models
{
    public record Locality (string LocalityName, 
                            decimal Latitude,
                            decimal Longtitude);
}