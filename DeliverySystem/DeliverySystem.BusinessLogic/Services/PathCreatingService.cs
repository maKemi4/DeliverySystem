using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using DeliverySystem.Infrastructure.DistanceAndTimeFinding;
using DeliverySystem.Infrastructure.DistanceAndTimeFinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services
{
    public class PathCreatingService : IPathCreatingService
    {
        private readonly IOrderItemService _orderItemService;
        private readonly IDistanceAndTimeFindingService _distanceAndTimeFindingService;
        private readonly IOptimalPathChoosingService _optimalPathChoosingService;

        public PathCreatingService(IOrderItemService orderItemService,
            IDistanceAndTimeFindingService distanceAndTimeFindingService,
            IOptimalPathChoosingService optimalPathChoosingService)
        {
            _orderItemService = orderItemService;
            _distanceAndTimeFindingService = distanceAndTimeFindingService;
            _optimalPathChoosingService = optimalPathChoosingService;
        }

        public async Task<BuiltPath> CreatePath(int orderId)
        {
            var records = await _orderItemService.GetOrderItems(orderId);
            var orderItems = new List<OrderItem>() { new OrderItem() { ImportanceRate = 0, LocalityName = "Kiev", Latitude = 0.0M, Longitude = 0.0M } };
            orderItems.AddRange(records);

            var size = orderItems.Count;

            var vertices = new int[size];
            var importanceRates = new decimal[size];
            var matrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                vertices[i] = i;
                importanceRates[i] = orderItems[i].ImportanceRate;
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 0;
                        continue;
                    }

                    var locality1 = new Locality(orderItems[i].LocalityName, orderItems[i].Latitude, orderItems[i].Longitude);
                    var locality2 = new Locality(orderItems[j].LocalityName, orderItems[j].Latitude, orderItems[j].Longitude);

                    var distanceAndTime = await _distanceAndTimeFindingService.CalculateDistanceAndTime(locality1, locality2);

                    matrix[i, j] = distanceAndTime.TimeBetweenPoints;
                }
            }

            var optimalPathResult = _optimalPathChoosingService.ChooseBestOne(vertices, matrix, importanceRates.AsEnumerable());
            var path = new List<PathLocality>();
            int order = 0;
            foreach(var item in optimalPathResult.ShortestPath)
            {
                path.Add(new PathLocality(orderItems[item].LocalityName, orderItems[item].Latitude, orderItems[item].Longitude, order));
                order++;
            }

            return new BuiltPath { 
                TotalImportanceRate = optimalPathResult.ImportanceRateCost, 
                TotalTime = optimalPathResult.TimeCost, 
                Path = path};
        }
    }
}
