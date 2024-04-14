using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public class DeliveryQueueItem
    {
        public int Id { get; set; }
        public bool IsCompleted { get; set; }
        public string Name { get; set; }
    }
}
