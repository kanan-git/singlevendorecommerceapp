using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.UnitofWork.Abstract;

public interface IUnitOfWork
{
    public IAddressRepository AddressRepository {get;}
    public IBrandRepository BrandRepository {get;}
    public ICartItemRepository CartItemRepository {get;}
    public ICategoryRepository CategoryRepository {get;}
    public ICommentRepository CommentRepository {get;}
    public ICouponRepository CouponRepository {get;}
    public ILanguageRepository LanguageRepository {get;}
    public IMediaFileRepository MediaFileRepository {get;}
    public IOrderRepository OrderRepository {get;}
    public IPaymentDetailRepository PaymentDetailRepository {get;}
    public IProductRepository ProductRepository {get;}
    public IShippingDetailRepository ShippingDetailRepository {get;}
    public IWishlistRepository WishlistRepository {get;}
    public Task<int> SaveAsync();
}
