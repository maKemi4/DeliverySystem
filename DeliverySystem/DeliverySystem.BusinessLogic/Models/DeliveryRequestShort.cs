using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public class DeliveryRequestShort : DeliveryRequest
    {
        public string CustomerFullName { get; set; }
        public string Email {  get; set; }
        public string PhoneNum { get; set; }
        public string LocalityName { get; set; }
        public int NumOfVictims { get; set; }
        public int? NumOfSeveralyVictims { get; set; }
        public string SituationDescription { get; set; }
        public int Importance { get; set; }
        public bool IsCompleted { get; set; }
    }
}
//Model for UI