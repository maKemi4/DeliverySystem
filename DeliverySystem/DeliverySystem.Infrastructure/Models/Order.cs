using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Infrastructure.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public decimal ImportanceRate { get; set; }
    }
}
