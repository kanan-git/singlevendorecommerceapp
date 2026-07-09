using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.Order;

namespace Business.Services.Concrete;

public class OrderServices : IOrderServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public OrderServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<OrderResponseDto>>> GetAllOrdersAsync()
    {
        var orders = await _unitOfWork.OrderRepository.GetAllAsync();
        var data = _mapper.Map<List<OrderResponseDto>>(orders);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<OrderResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<OrderResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<OrderResponseDto>>> GetAllOrdersPaginatedAsync(int page, int size)
    {
        var orders = await _unitOfWork.OrderRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<OrderResponseDto>>(orders);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<OrderResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<OrderResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<OrderResponseDto>> GetOrderByIdAsync(Guid id)
    {
        var order = await _unitOfWork.OrderRepository.GetAsync(o => o.Id==id);
        if(order == null)
        {
            return new ErrorDataResult<OrderResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<OrderResponseDto>(order);
        return new SuccessDataResult<OrderResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewOrderAsync(OrderCreateDto createDto)
    {
        var newOrder = _mapper.Map<Order>(createDto);
        try{
            await _unitOfWork.OrderRepository.AddAsync(newOrder);
            var result = await _unitOfWork.OrderRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateOrder(Guid id, OrderUpdateDto updateDto)
    {
        var order = await _unitOfWork.OrderRepository.GetAsync(o => o.Id==id);
        if(order == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, order);
            _unitOfWork.OrderRepository.Update(order);
            await _unitOfWork.OrderRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteOrder(Guid id)
    {
        var order = await _unitOfWork.OrderRepository.GetAsync(o => o.Id==id);
        if(order == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.OrderRepository.Remove(order);
            await _unitOfWork.OrderRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
