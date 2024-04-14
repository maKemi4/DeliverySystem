using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.Models
{
    public class DeliveryQueueRecord
    {
        public int Id { get; set; }
        public int NumOfVictims { get; set; }
        public int? NumOfSeverelyVictims { get; set; }
        public string Description { get; set; }
        public int ConditionType { get; set; }
        public decimal ImportanceRate { get; set; }
        public decimal Longtitued { get; set; }
        public string PhoneNumber { get; set; }
    }
}
