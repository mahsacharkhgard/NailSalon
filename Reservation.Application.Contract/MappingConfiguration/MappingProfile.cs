using AutoMapper;
using Reservation.Application.Contract.Dtos.Customers;
using Reservation.Application.Contract.Dtos.DesignNails;
using Reservation.Application.Contract.Dtos.NailServices;
using Reservation.Application.Contract.Dtos.Personnels;
using Reservation.Model.Models;

namespace Reservation.Application.Contract.MappingConfiguration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NailService, NailServiceDto>();
            CreateMap<Customer,CustomerDto>().ReverseMap();
            CreateMap<CustomerAddDto, Customer>();
            CreateMap<Personnel, PersonnelDto>();
            CreateMap<DesignNail,DesignNailDto>();
        }
    }
}
