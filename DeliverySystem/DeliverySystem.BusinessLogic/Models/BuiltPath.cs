using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public class BuiltPath
    {
        public double TotalTime { get; set; }
        public double TotalImportanceRate { get; set; }
        public IEnumerable<PathLocality> Path { get; set; }
    } 
    
    public record PathLocality (string Name, decimal Latitude, decimal Longitude, int Order);
}
