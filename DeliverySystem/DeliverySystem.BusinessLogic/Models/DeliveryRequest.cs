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
        public Requirements Requirements { get; set; }
        // Copy AddDeliveryRequestModel 
    }

    public class ContactInformation
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string NameOfSettlement { get; set; }

        //....
    }

    public class Requirements
    {
        public int NumOfVictims { get; set; }
        public int? NumOfSeverelyVictims { get; set; }
        public IEnumerable<string> NeededMediсine { get; set; }
        public ConditionType Condition { get; set; }

        // ....

    }

    // ЗАПИТ
}
