using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.Address;

namespace Business.Profiles;

public class AddressMapper : Profile
{
    public AddressMapper()
    {
        CreateMap<AddressCreateDto, Address>().ReverseMap();
        CreateMap<Address, AddressResponseDto>().ReverseMap();
        CreateMap<AddressUpdateDto, Address>().ReverseMap();
    }
}
