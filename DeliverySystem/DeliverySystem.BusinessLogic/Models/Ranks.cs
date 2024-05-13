using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Models
{
    public static class Ranks
    {
        public static Dictionary<string, int> Get()
        {
            return new Dictionary<string, int>()
            {
                { "ConditionType: Default", 1 },
                { "ConditionType: Bombing", 16 },
                { "ConditionType: NaturalDisasters", 10 },
                { "ConditionType: InfrastructureDamaged", 7 },
                { "Importance: None", 2 },
                { "Importance: Low", 4 },
                { "Importance: Medium", 8 },
                { "Importance: High", 14 },
                { "AgeGroup: _1_14", 13 },
                { "AgeGroup: _1_21", 9 },
                { "AgeGroup: _1_39", 6 },
                { "AgeGroup: _1_90", 11 },
                { "NeededSpecialist: NotNeeded", 3 },
                { "NeededSpecialist: FieldSurgeon", 12 },
                { "NeededSpecialist: Psychiatrist", 5 },
                { "NeededSpecialist: FieldSurgeonAndPsychiatrist", 15 },
            };
        }
    }
}
