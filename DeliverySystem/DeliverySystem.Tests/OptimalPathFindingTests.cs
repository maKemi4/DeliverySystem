using DeliverySystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DeliverySystem.BusinessLogic.Services;
using DeliverySystem.BusinessLogic.Models;

namespace DeliverySystem.Tests
{
    [TestFixture]
    public class OptimalPathFindingTests
    {
        [Test]
        public void Find_Default_Route_Test()
        {
            //Arrange
            var vertics = new int[5] { 0, 1, 2, 3, 4 };
            var importanceRates = new double[5] { 0, 2.5, 3.1, 1.1, 0.5 };
            var matrix = new double[5, 5]
            {
                { 0, 4, 7, 11, 9 },
                { 4, 0, 6, 12, 7 },
                { 7, 6, 0, 3, 9 },
                { 11, 12, 3, 0, 5 },    
                { 9, 7, 10, 5, 0 }
            };
            var expectedCost = 26.0;
            var expectedImportanceCost = 99.0;
            var expectedRoute = new int[6] { 0, 1, 4, 3, 2, 0 };

            //Act
            var service = new OptimalPathFindingService();
            PathResult result = service.FindFinalPath(vertics, matrix, importanceRates, false);

            IEnumerable<int> shortestPath = result.ShortestPath;
            double cost = result.TimeCost;
            double importanceRate = result.ImportanceRateCost;

            //Assert
            Assert.AreEqual(expectedCost, cost);
            Assert.AreEqual(expectedImportanceCost, importanceRate);
            Assert.IsTrue(CheckArraysAreEqual(expectedRoute, shortestPath.ToArray()));
        }

        [Test]
        public void Find_Route_With_Importance_Rate_Test()
        {
            //Arrange
            var vertics = new int[4] { 0, 1, 2, 3};
            var matrix = new double[4, 4]
            {
                { 0, 1, 3, 2 },
                { 1, 0, 4, 5 },
                { 3, 4, 0, 20 },
                { 2, 5, 20, 0 }
            };
            var importanceRates = new double[4] { 0, 2.5, 3.1, 1.1 };

            var expectedCost = 14.0;
            var expectedImportanceCost = 42.0;
            var expectedRoute = new int[5] { 0, 2, 1, 3, 0 };

            //Act
            var service = new OptimalPathFindingService();
            PathResult result = service.FindFinalPath(vertics, matrix, importanceRates, true);

            IEnumerable<int> shortestPath = result.ShortestPath;
            double cost = result.TimeCost;
            double importanceRate = result.ImportanceRateCost;

            //Assert
            Assert.AreEqual(expectedCost, cost);
            Assert.AreEqual(expectedImportanceCost, importanceRate);
            Assert.IsTrue(CheckArraysAreEqual(expectedRoute, shortestPath.ToArray()));
        }

        [Test]
        public void Choose_One_Of_Paths_Test()
        {
            //Arrange
            var vertics = new int[5] { 0, 1, 2, 3, 4 };
            var importanceRates = new double[5] { 0, 2.5, 3.1, 1.1, 0.5 };
            var matrix = new double[5, 5]
            {
                { 0, 4, 7, 11, 9 },
                { 4, 0, 6, 12, 7 },
                { 7, 6, 0, 3, 9 },
                { 11, 12, 3, 0, 5 },
                { 9, 7, 10, 5, 0 }
            };

            var expectedCost = 27.0;
            var expectedImportanceCost = 73.3;
            var expectedRoute = new int[6] { 0, 1, 2, 3, 4, 0 };

            //Act
            var service = new OptimalPathChoosingService();

            PathResult result = service.ChooseOne(vertics, matrix, importanceRates);

            IEnumerable<int> shortestPath = result.ShortestPath;
            double cost = result.TimeCost;
            double importanceRate = result.ImportanceRateCost;

            //Assert
            Assert.AreEqual(expectedCost, cost);
            Assert.AreEqual(expectedImportanceCost, importanceRate);
            Assert.IsTrue(CheckArraysAreEqual(expectedRoute, shortestPath.ToArray()));
        }

        private bool CheckArraysAreEqual(int[] expectedRoute, int[] actual)
        {
            if (expectedRoute.Length != actual.Length)
            {
                return false;
            }  
            
            for (int i = 0; i<expectedRoute.Length; i++)
            {
                if (expectedRoute[i] != actual[i])
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}