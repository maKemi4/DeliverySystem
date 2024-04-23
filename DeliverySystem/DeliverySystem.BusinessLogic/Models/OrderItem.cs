using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int DeliveryRequestId { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public int Importance { get; set; }
        public string LocalityName { get; set; }
        public decimal ImportanceRate { get; set; }
    }
}
