using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using DataAccessLayer.Repositories.Concrete.EFCore;
using DataAccessLayer.UnitofWork.Abstract;

namespace DataAccessLayer.UnitofWork.Concrete;

public class UnitOfWork : IUnitOfWork
{
    private readonly ECommerceDbContext _dbContext;
    private IAddressRepository? _addressRepo;
    private IBrandRepository? _brandRepo;
    private ICartItemRepository? _cartItemRepo;
    private ICategoryRepository? _categoryRepo;
    private ICommentRepository? _commentRepo;
    private ICouponRepository? _couponRepo;
    private ILanguageRepository? _languageRepo;
    private IMediaFileRepository? _mediaFileRepo;
    private IOrderRepository? _orderRepo;
    private IPaymentDetailRepository? _paymentDetailRepo;
    private IProductRepository? _productRepo;
    private IShippingDetailRepository? _shippingDetailRepo;
    private IWishlistRepository? _wishlistRepo;
    public UnitOfWork(ECommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IAddressRepository AddressRepository => _addressRepo ??= new AddressRepository(_dbContext);
    public IBrandRepository BrandRepository => _brandRepo ??= new BrandRepository(_dbContext);
    public ICartItemRepository CartItemRepository => _cartItemRepo ??= new CartItemRepository(_dbContext);
    public ICategoryRepository CategoryRepository => _categoryRepo ??= new CategoryRepository(_dbContext);
    public ICommentRepository CommentRepository => _commentRepo ??= new CommentRepository(_dbContext);
    public ICouponRepository CouponRepository => _couponRepo ??= new CouponRepository(_dbContext);
    public ILanguageRepository LanguageRepository => _languageRepo ??= new LanguageRepository(_dbContext);
    public IMediaFileRepository MediaFileRepository => _mediaFileRepo ??= new MediaFileRepository(_dbContext);
    public IOrderRepository OrderRepository => _orderRepo ??= new OrderRepository(_dbContext);
    public IPaymentDetailRepository PaymentDetailRepository => _paymentDetailRepo ??= new PaymentDetailRepository(_dbContext);
    public IProductRepository ProductRepository => _productRepo ??= new ProductRepository(_dbContext);
    public IShippingDetailRepository ShippingDetailRepository => _shippingDetailRepo ??= new ShippingDetailRepository(_dbContext);
    public IWishlistRepository WishlistRepository => _wishlistRepo ??= new WishlistRepository(_dbContext);
    public async Task<int> SaveAsync() => await _dbContext.SaveChangesAsync();
}
