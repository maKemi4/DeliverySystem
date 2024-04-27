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
        double averageSpeed = 60; //??

        public Task<DistanceAndTime> CalculateDistanceAndTime(Locality firstLocality, Locality secondLocality)
        {
            var firstLocalityCordinate = new GeoCoordinate(firstLocality.Latitude, firstLocality.Longtitude);
            var secondLocalityCordinate = new GeoCoordinate(secondLocality.Latitude, secondLocality.Longtitude);

            var distance = firstLocalityCordinate.GetDistanceTo(secondLocalityCordinate) / 1000; //GetDistanceTo вертає відстань в метрах
            var distanceTime = distance / averageSpeed;
            var localityNames = $"{firstLocality.LocalityName}, {secondLocality.LocalityName}";

            return Task.FromResult(new DistanceAndTime(distance, distanceTime, localityNames));
        }
    }
}
