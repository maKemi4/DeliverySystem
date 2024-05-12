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
                { "ConditionType: Default", 2 },
                { "ConditionType: Bombing", 17 },
                { "ConditionType: NaturalDisasters", 12 },
                { "ConditionType: InfrastructureDamaged", 9 },
                { "Importance: None", 1 },
                { "Importance: Low", 4 },
                { "Importance: Medium", 10 },
                { "Importance: High", 13 },
                { "AgeGroup: _1_14", 15 },
                { "AgeGroup: _15_21", 8 },
                { "AgeGroup: _22_39", 6 },
                { "AgeGroup: _40_90", 11 },
                { "InjuriesType: SkullAndBrainInjuries", 16 },
                { "InjuriesType: InternalOrgansInjuries", 14 },
                { "InjuriesType: LimbInjuries", 7 },
                { "InjuriesType: BurnsAndSkinInjuries", 5 },
                { "InjuriesType: PsychologicalInjuries", 3 }
            };
        }
    }
}
