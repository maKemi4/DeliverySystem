﻿using AutoMapper;
using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.BusinessLogic.Services.Abstractions;
using DeliverySystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Services
{
    public class DeliveryQueueImportanceService : IDeliveryQueueImportanceService
    {
        private readonly IDeliveryQueueRepository _deliveryQueueRepository;

        private Dictionary<string, double> GetWeight()
        {
            var weights = new Dictionary<string, double>(); 
            var ranks = Ranks.Get();

            int minRank = ranks.Values.Min();
            int maxRank = ranks.Values.Max();

            foreach (var item in ranks)
            {
                double weight = ((double)(item.Value - minRank) / (maxRank - minRank));
                weights.Add(item.Key, weight);
            }

            return weights;
        }

        public decimal Calculate(Requirements requirements)
        {
            var weights = GetWeight();
            //var averageNumOfVictims = await _deliveryQueueRepository.GetAverageNumOfVictims();

            var averageNumOfVictims = 25.0;

            var numOfVictimsWeight = requirements.NumOfVictims / averageNumOfVictims;
            var numOfSeveralyVictimsWeight = requirements.NumOfSeveralyVictims / averageNumOfVictims;

            var conditionTypeWeight = weights[$"ConditionType: {requirements.ConditionType.ToString()}"];
            var importanceWeight = weights[$"Importance: {requirements.Importance.ToString()}"];
            var ageGroupWeight = weights[$"AgeGroup: {requirements.AgeGroup.ToString()}"];
            var neededSpecialistWeight = weights[$"NeededSpecialist: {requirements.NeededSpecialist.ToString()}"];

            

            var importanceRate = numOfVictimsWeight + numOfSeveralyVictimsWeight + 
                conditionTypeWeight + importanceWeight + ageGroupWeight + neededSpecialistWeight;

            return Convert.ToDecimal(importanceRate);
        }
    }
}
