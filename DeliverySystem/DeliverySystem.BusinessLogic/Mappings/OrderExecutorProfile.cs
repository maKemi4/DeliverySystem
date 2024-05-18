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
    public class OrderExecutorProfile : Profile
    {
        public OrderExecutorProfile()
        {
            CreateMap<OrderExecutor, OrderExecutorInfo>()
                .ForMember(dest => dest.ExecutorName, opt => opt.MapFrom(src => src.ExecutorName))
                .ForMember(dest => dest.OrderExecutorId, opt => opt.MapFrom(src => src.OrderExecutorId))
                .ForMember(dest => dest.ExecutorSurname, opt => opt.MapFrom(src => src.ExecutorSurname))
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.OrganizationName));
        }
    }
}
