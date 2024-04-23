using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.Models
{
    public class DeliveryQueueFullRequestInformation
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }

        public string LocalityName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longtitude { get; set; }
        public int NumOfVictims { get; set; }
        public int NumOfSeveralyVictims { get; set; }
        public int ConditionType { get; set; }
        public string SituationDescription { get; set; }

        public int DeliveryQueueId { get; set; }
        public int Importance { get; set; }
        public decimal ImportanceRate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
