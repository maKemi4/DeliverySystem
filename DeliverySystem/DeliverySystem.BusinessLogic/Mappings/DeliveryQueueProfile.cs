using AutoMapper;
using DeliverySystem.BusinessLogic.Models;
using DeliverySystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.BusinessLogic.Mappings
{
    public class DeliveryQueueProfile : Profile
    {
        public DeliveryQueueProfile() 
        {
            CreateMap<DeliveryRequest, DeliveryQueueRecord>()
                .ForMember(dest => dest.NumOfVictims, opt => opt.MapFrom(src => src.Requirements.NumOfVictims))
                .ForMember(dest => dest.Importance, opt => opt.Ignore());
        }
    }
}
