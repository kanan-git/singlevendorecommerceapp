using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.PaymentDetail;

namespace Business.Profiles;

public class PaymentDetailMapper : Profile
{
    public PaymentDetailMapper()
    {
        CreateMap<PaymentDetailCreateDto, PaymentDetail>().ReverseMap();
        CreateMap<PaymentDetail, PaymentDetailResponseDto>().ReverseMap();
        CreateMap<PaymentDetailUpdateDto, PaymentDetail>().ReverseMap();
    }
}
