using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.BLL.Concrete;
using YapGetirCom.DAL;

namespace YapGetirCom.BLL
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private IUnitOfWork _unitOfWork;
        private YapGetirComDbContext _db;

        public UnitOfWorkService(YapGetirComDbContext db)
        {
            //_unitOfWork = new UnitOfWork(new YapGetirComDbContext());

            //_db = db;

            //CampaignService = new CampaignService(_db);
            //CategoryService = new CategoryService(_db);
            //CategoryTypeService = new CategoryTypeService(_db);
            //CommentService = new CommentService(_db);
            //CookService = new CookService(_db);
            //MaterialService = new MaterialService(_db);
            //MessageService = new MessageService(_db);
            //OrderService = new OrderService(_db);
            //PaymentService = new PaymentService(_db);
            //ProductOrderDetailService = new ProductOrderDetailService(_db);
            //ProductOrderService = new ProductOrderService(_db);
            //ProductService = new ProductService(_db);
            //RecipeService = new RecipeService(_db);
            //RestaurantService = new RestaurantService(_db);
            //ScoringService = new ScoringService(_db);
            //SharedService = new SharedService(_db);
            //StockService = new StockService(_db);
            //SupplierService = new SupplierService(_db);
            //UserService = new UserService(_db);
            //UserTypeService = new UserTypeService(_db);
        }

        public ICampaignService CampaignService { get; }
        public ICategoryService CategoryService { get; }
        public ICategoryTypeService CategoryTypeService { get; }
        public ICommentService CommentService { get; }
        public ICookService CookService { get; }
        public IMaterialService MaterialService { get; }
        public IMessageService MessageService { get; }
        public IOrderService OrderService { get; }
        public IPaymentService PaymentService { get; }
        public IProductOrderDetailService ProductOrderDetailService { get; }
        public IProductOrderService ProductOrderService { get; }
        public IProductService ProductService { get; }
        public IRecipeService RecipeService { get; }
        public IRestaurantService RestaurantService { get; }
        public IScoringService ScoringService { get; }
        public ISharedService SharedService { get; }
        public IStockService StockService { get; }
        public ISupplierService SupplierService { get; }
        public IUserService UserService { get; }
        public IUserTypeService UserTypeService { get; }

        public void Complete()
        {
            _unitOfWork.Complete();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
