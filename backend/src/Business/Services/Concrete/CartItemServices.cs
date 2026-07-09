using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.CartItem;

namespace Business.Services.Concrete;

public class CartItemServices : ICartItemServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CartItemServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<CartItemResponseDto>>> GetAllCartItemsAsync()
    {
        var cartitems = await _unitOfWork.CartItemRepository.GetAllAsync(filter:null, "Brand","Category");
        var data = _mapper.Map<List<CartItemResponseDto>>(cartitems);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<CartItemResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<CartItemResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<CartItemResponseDto>>> GetAllCartItemsPaginatedAsync(int page, int size)
    {
        var cartitems = await _unitOfWork.CartItemRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<CartItemResponseDto>>(cartitems);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<CartItemResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<CartItemResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<CartItemResponseDto>> GetCartItemByIdAsync(Guid id)
    {
        var cartitem = await _unitOfWork.CartItemRepository.GetAsync(ci => ci.Id==id);
        if(cartitem == null)
        {
            return new ErrorDataResult<CartItemResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<CartItemResponseDto>(cartitem);
        return new SuccessDataResult<CartItemResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewCartItemAsync(CartItemCreateDto createDto)
    {
        var newCartItem = _mapper.Map<CartItem>(createDto);
        try{
            await _unitOfWork.CartItemRepository.AddAsync(newCartItem);
            var result = await _unitOfWork.CartItemRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateCartItem(Guid id, CartItemUpdateDto updateDto)
    {
        var cartitem = await _unitOfWork.CartItemRepository.GetAsync(ci => ci.Id==id);
        if(cartitem == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, cartitem);
            _unitOfWork.CartItemRepository.Update(cartitem);
            await _unitOfWork.CartItemRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteCartItem(Guid id)
    {
        var cartitem = await _unitOfWork.CartItemRepository.GetAsync(ci => ci.Id==id);
        if(cartitem == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.CartItemRepository.Remove(cartitem);
            await _unitOfWork.CartItemRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
