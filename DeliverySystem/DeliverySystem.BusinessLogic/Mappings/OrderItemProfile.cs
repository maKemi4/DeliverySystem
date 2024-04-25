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
    public class OrderItemProfile : Profile
    {
        public OrderItemProfile()
        {
            CreateMap<OrderRecord, OrderItem>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.OrderId))
                .ForMember(dest => dest.DeliveryRequestId, opt => opt.MapFrom(src => src.DeliveryRequestId))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Longitude))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Latitude))
                .ForMember(dest => dest.Importance, opt => opt.MapFrom(src => src.Importance))
                .ForMember(dest => dest.LocalityName, opt => opt.MapFrom(src => src.LocalityName))
                .ForMember(dest => dest.ImportanceRate, opt => opt.MapFrom(src => src.ImportanceRate));
        }
    }
}
