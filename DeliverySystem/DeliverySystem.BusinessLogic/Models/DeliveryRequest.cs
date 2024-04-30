using DeliverySystem.Shared.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public class DeliveryRequest
    {
        public ContactInformation ContactInformation { get; set; }
        public Requirements Requirements { get; set; } 
    }

    public class ContactInformation
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string LocalityName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longtitude { get; set; }
    }

    public class Requirements
    {
        public int NumOfVictims { get; set; }
        public int? NumOfSeveralyVictims { get; set; }
        public ConditionType ConditionType { get; set; }
        public Importance Importance { get; set; }
        public AgeGroup AgeGroup { get; set; }
        public InjuriesType InjuriesType { get; set; }
        public string SituationDescription { get; set; }
    }
}
