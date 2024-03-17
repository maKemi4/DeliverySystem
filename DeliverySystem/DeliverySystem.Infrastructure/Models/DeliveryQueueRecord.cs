using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.Models
{
    public class DeliveryQueueRecord
    {
        public int NumOfVictims { get; set; }
        public int? NumOfSeverelyVictims { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public decimal Importance { get; set; }
    }
}
