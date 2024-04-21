using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.Models
{
    public class DeliveryQueueRecords
    {
        public int DeliveryQueueId { get; set; }
        public decimal ImportanceRate { get; set; }
        public DateTime SubmissionDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
