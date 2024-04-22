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
            CreateMap<DeliveryRequest, DeliveryQueueFullRequestInformation>()
                .ForMember(dest => dest.NumOfVictims, opt => opt.MapFrom(src => src.Requirements.NumOfVictims))
                .ForMember(dest => dest.NumOfSeveralyVictims, opt => opt.MapFrom(src => src.Requirements.NumOfSeveralyVictims))
                //.ForMember(dest => dest.NeededMecine, opt => opt.MapFrom(src => src.Requirements.NumOfSeveralyVictims))
                .ForMember(dest => dest.ConditionType, opt => opt.MapFrom(src => src.Requirements.ConditionType))
                .ForMember(dest => dest.SituationDescription, opt => opt.MapFrom(src => src.Requirements.SituationDescription))
                .ForMember(dest => dest.Importance, opt => opt.MapFrom(src => src.Requirements.Importance))
                .ForMember(dest => dest.ImportanceRate, opt => opt.Ignore())
                .ForMember(dest => dest.isCompleted, opt => opt.MapFrom(src => src.Requirements.isCompleted))

                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.ContactInformation.CustomerName))
                .ForMember(dest => dest.CustomerSurname, opt => opt.MapFrom(src => src.ContactInformation.CustomerSurname))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.ContactInformation.Email))
                .ForMember(dest => dest.PhoneNum, opt => opt.MapFrom(src => src.ContactInformation.PhoneNum))
                .ForMember(dest => dest.LocalityName, opt => opt.MapFrom(src => src.ContactInformation.LocalityName))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.ContactInformation.Latitude))
                .ForMember(dest => dest.Longtitude, opt => opt.MapFrom(src => src.ContactInformation.Longtitude));

            CreateMap<DeliveryRequest, DeliveryQueueItem>()
                ;
        }
    }
}
