using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.BLL.Concrete;
using YapGetirCom.DAL;
using YapGetirCom.DAL.Repositories.Concrete;

namespace YapGetirCom.UI.MVC.App_Start
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _kernel;
        private readonly YapGetirComDbContext db;
        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            db = new YapGetirComDbContext();
            AddBllBindings();
        }

        private void AddBllBindings()
        {
            this._kernel.Bind<ICampaignService>().To<CampaignService>().WithConstructorArgument("_campaignRepository", new CampaignRepository(db));
            this._kernel.Bind<ICategoryService>().To<CategoryService>().WithConstructorArgument("_categoryRepository", new CategoryRepository(db));
            this._kernel.Bind<ICategoryTypeService>().To<CategoryTypeService>().WithConstructorArgument("_categoryTypeRepository", new CategoryTypeRepository(db));
            this._kernel.Bind<ICommentService>().To<CommentService>().WithConstructorArgument("_commentRepository", new CommentRepository(db));
            this._kernel.Bind<ICookService>().To<CookService>().WithConstructorArgument("_cookRepository", new CookRepository(db));
            this._kernel.Bind<IMaterialService>().To<MaterialService>().WithConstructorArgument("_materialRepository", new MaterialRepository(db));
            this._kernel.Bind<IMessageService>().To<MessageService>().WithConstructorArgument("_messageRepository", new MessageRepository(db));
            this._kernel.Bind<IOrderService>().To<OrderService>().WithConstructorArgument("_orderRepository", new OrderRepository(db));
            this._kernel.Bind<IPaymentService>().To<PaymentService>().WithConstructorArgument("_paymentRepository", new PaymentRepository(db));
            this._kernel.Bind<IProductOrderDetailService>().To<ProductOrderDetailService>().WithConstructorArgument("_productOrderDetailRepository", new ProductOrderDetailRepository(db));
            this._kernel.Bind<IProductOrderService>().To<ProductOrderService>().WithConstructorArgument("_productOrderRepository", new ProductOrderRepository(db));
            this._kernel.Bind<IProductService>().To<ProductService>().WithConstructorArgument("_productRepository", new ProductRepository(db));
            this._kernel.Bind<IRecipeService>().To<RecipeService>().WithConstructorArgument("_recipeRepository", new RecipeRepository(db));
            this._kernel.Bind<IRestaurantService>().To<RestaurantService>().WithConstructorArgument("_restaurantRepository", new RestaurantRepository(db));
            this._kernel.Bind<IScoringService>().To<ScoringService>().WithConstructorArgument("_scoringRepository", new ScoringRepository(db));
            this._kernel.Bind<ISharedService>().To<SharedService>().WithConstructorArgument("_sharedRepository", new SharedRepository(db));
            this._kernel.Bind<IStockService>().To<StockService>().WithConstructorArgument("_stockRepository", new StockRepository(db));
            this._kernel.Bind<ISupplierService>().To<SupplierService>().WithConstructorArgument("_supplierRepository", new SupplierRepository(db));
            this._kernel.Bind<IUserService>().To<UserService>().WithConstructorArgument("_userRepository", new UserRepository(db));
            this._kernel.Bind<IUserTypeService>().To<UserTypeService>().WithConstructorArgument("_userTypeRepository", new UserTypeRepository(db));
        }
    }
}