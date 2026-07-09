using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using DataAccessLayer.Repositories.Concrete.EFCore;
using DataAccessLayer.UnitofWork.Abstract;

namespace DataAccessLayer.UnitofWork.Concrete;

public class UnitOfWork : IUnitOfWork
{
    private readonly ECommerceDbContext _dbContext;
    private readonly IAddressRepository _addressRepo;
    private readonly IBrandRepository _brandRepo;
    private readonly ICartItemRepository _cartItemRepo;
    private readonly ICategoryRepository _categoryRepo;
    private readonly ICommentRepository _commentRepo;
    private readonly ICouponRepository _couponRepo;
    private readonly ILanguageRepository _languageRepo;
    private readonly IMediaFileRepository _mediaFileRepo;
    private readonly IOrderRepository _orderRepo;
    private readonly IPaymentDetailRepository _paymentDetailRepo;
    private readonly IProductRepository _productRepo;
    private readonly IShippingDetailRepository _shippingDetailRepo;
    private readonly IWishlistRepository _wishlistRepo;
    public UnitOfWork(ECommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IAddressRepository AddressRepository => _addressRepo ?? new AddressRepository(_dbContext);
    public IBrandRepository BrandRepository => _brandRepo ?? new BrandRepository(_dbContext);
    public ICartItemRepository CartItemRepository => _cartItemRepo ?? new CartItemRepository(_dbContext);
    public ICategoryRepository CategoryRepository => _categoryRepo ?? new CategoryRepository(_dbContext);
    public ICommentRepository CommentRepository => _commentRepo ?? new CommentRepository(_dbContext);
    public ICouponRepository CouponRepository => _couponRepo ?? new CouponRepository(_dbContext);
    public ILanguageRepository LanguageRepository => _languageRepo ?? new LanguageRepository(_dbContext);
    public IMediaFileRepository MediaFileRepository => _mediaFileRepo ?? new MediaFileRepository(_dbContext);
    public IOrderRepository OrderRepository => _orderRepo ?? new OrderRepository(_dbContext);
    public IPaymentDetailRepository PaymentDetailRepository => _paymentDetailRepo ?? new PaymentDetailRepository(_dbContext);
    public IProductRepository ProductRepository => _productRepo ?? new ProductRepository(_dbContext);
    public IShippingDetailRepository ShippingDetailRepository => _shippingDetailRepo ?? new ShippingDetailRepository(_dbContext);
    public IWishlistRepository WishlistRepository => _wishlistRepo ?? new WishlistRepository(_dbContext);
    public async Task<int> SaveAsync() => await _dbContext.SaveChangesAsync();
}
