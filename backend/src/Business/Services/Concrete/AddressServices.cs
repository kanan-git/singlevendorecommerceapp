using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.Address;

namespace Business.Services.Concrete;

public class AddressServices : IAddressServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public AddressServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<AddressResponseDto>>> GetAllAddressesAsync()
    {
        var addresses = await _unitOfWork.AddressRepository.GetAllAsync(filter:null, "Brand","Category");
        var data = _mapper.Map<List<AddressResponseDto>>(addresses);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<AddressResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<AddressResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<AddressResponseDto>>> GetAllAddressesPaginatedAsync(int page, int size)
    {
        var addresses = await _unitOfWork.AddressRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<AddressResponseDto>>(addresses);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<AddressResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<AddressResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<AddressResponseDto>> GetAddressByIdAsync(Guid id)
    {
        var address = await _unitOfWork.AddressRepository.GetAsync(a => a.Id==id);
        if(address == null)
        {
            return new ErrorDataResult<AddressResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<AddressResponseDto>(address);
        return new SuccessDataResult<AddressResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewAddressAsync(AddressCreateDto createDto)
    {
        var newAddress = _mapper.Map<Address>(createDto);
        try{
            await _unitOfWork.AddressRepository.AddAsync(newAddress);
            var result = await _unitOfWork.AddressRepository.SaveAsync();
            if(result > 0)
            {
                return new SuccessResult(message:ResultMessages.Created);
            }
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
        catch(Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateAddress(Guid id, AddressUpdateDto updateDto)
    {
        var address = await _unitOfWork.AddressRepository.GetAsync(a => a.Id==id);
        if(address == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, address);
            _unitOfWork.AddressRepository.Update(address);
            await _unitOfWork.AddressRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteAddress(Guid id)
    {
        var address = await _unitOfWork.AddressRepository.GetAsync(a => a.Id==id);
        if(address == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.AddressRepository.Remove(address);
            await _unitOfWork.AddressRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
