using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services;
using DeliverySystem.Shared.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Tests
{
    [TestFixture]
    public class DeliveryQueueImportanceServiceTests
    {
        [Test]
        public void Find_Default_Route_Test()
        {
            var requirements = new Requirements
            {
                NumOfVictims = 10,
                NumOfSeveralyVictims = 5,
                ConditionType = ConditionType.Default,
                Importance = Importance.Low,
                AgeGroup = AgeGroup._1_14,
                InjuriesType = InjuriesType.BurnsAndSkinInjuries,
            };

            var expectedImportanceRate = 1.975;

            //Act
            var service = new DeliveryQueueImportanceService();
            var result = service.Calculate(requirements);

            //Assert
            Assert.AreEqual(expectedImportanceRate, Convert.ToDecimal(result));
        }
    }
}
