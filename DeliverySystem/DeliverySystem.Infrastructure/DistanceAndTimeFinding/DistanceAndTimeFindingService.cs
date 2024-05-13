using DeliverySystem.Infrastructure.DistanceAndTimeFinding;
using DeliverySystem.Infrastructure.DistanceAndTimeFinding.Models;
using DeliverySystem.Infrastructure.Models;
using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeliverySystem.Infrastructure.DistanceAndTimeFinding
{
    public class DistanceAndTimeFindingService : IDistanceAndTimeFindingService
    {
        private double averageSpeed = 60.0; //??

        public Task<DistanceAndTime> CalculateDistanceAndTime(Locality firstLocality, Locality secondLocality)
        {
            var firstLocalityCordinate = new GeoCoordinate((double)firstLocality.Latitude, (double)firstLocality.Longtitude);
            var secondLocalityCordinate = new GeoCoordinate((double)secondLocality.Latitude, (double)secondLocality.Longtitude);

            var distance = firstLocalityCordinate.GetDistanceTo(secondLocalityCordinate) / 1000.0; //GetDistanceTo вертає відстань в метрах
            var distanceTime = distance / averageSpeed;
            var localityNames = $"{firstLocality.LocalityName}, {secondLocality.LocalityName}";

            return Task.FromResult(new DistanceAndTime(distance, distanceTime, localityNames));
        }
    }
}
