using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.Wishlist;

namespace Business.Services.Concrete;

public class WishlistServices : IWishlistServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public WishlistServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<WishlistResponseDto>>> GetAllWishlistsAsync()
    {
        var wishlists = await _unitOfWork.WishlistRepository.GetAllAsync();
        var data = _mapper.Map<List<WishlistResponseDto>>(wishlists);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<WishlistResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<WishlistResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<WishlistResponseDto>>> GetAllWishlistsPaginatedAsync(int page, int size)
    {
        var wishlists = await _unitOfWork.WishlistRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<WishlistResponseDto>>(wishlists);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<WishlistResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<WishlistResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<WishlistResponseDto>> GetWishlistByIdAsync(Guid id)
    {
        var wishlist = await _unitOfWork.WishlistRepository.GetAsync(wl => wl.Id==id);
        if(wishlist == null)
        {
            return new ErrorDataResult<WishlistResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<WishlistResponseDto>(wishlist);
        return new SuccessDataResult<WishlistResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewWishlistAsync(WishlistCreateDto createDto)
    {
        var newWishlist = _mapper.Map<Wishlist>(createDto);
        try{
            await _unitOfWork.WishlistRepository.AddAsync(newWishlist);
            var result = await _unitOfWork.WishlistRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateWishlist(Guid id, WishlistUpdateDto updateDto)
    {
        var wishlist = await _unitOfWork.WishlistRepository.GetAsync(wl => wl.Id==id);
        if(wishlist == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, wishlist);
            _unitOfWork.WishlistRepository.Update(wishlist);
            await _unitOfWork.WishlistRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteWishlist(Guid id)
    {
        var wishlist = await _unitOfWork.WishlistRepository.GetAsync(wl => wl.Id==id);
        if(wishlist == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.WishlistRepository.Remove(wishlist);
            await _unitOfWork.WishlistRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
