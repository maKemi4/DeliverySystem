using DeliverySystem.Shared.Enumerations;

namespace DeliverySystem.WebAPI.Models
{
    public class AddDeliveryRequestModel
    {
        public ContactInformation ContactInformation { get; set; }
    }

    public class ContactInformation 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Settlement { get; set; }

        //....
    }

    public class Requirements
    {
        public int NumOfVictims  { get; set; }
        public int AgeOfVictims  { get; set; }
        public int? NumOfSeverelyVictims { get; set; } 
        public IEnumerable<string> NeededMediсine { get; set; }
        public ConditionType Condition {  get; set; }

        // ....
        
    }

    // ЗАПИТ

}
