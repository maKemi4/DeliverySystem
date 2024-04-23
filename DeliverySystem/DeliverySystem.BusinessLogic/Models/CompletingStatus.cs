using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public class CompletingStatus : DeliveryQueueItem
    {
        public bool IsCompleted { get; set; }
    }
}
