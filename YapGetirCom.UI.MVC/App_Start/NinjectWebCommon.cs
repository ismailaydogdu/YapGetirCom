[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(YapGetirCom.UI.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(YapGetirCom.UI.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace YapGetirCom.UI.MVC.App_Start
{
 using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using YapGetirCom.BLL.Abstract;
    using YapGetirCom.BLL.Concrete;
    using YapGetirCom.BLL.IoC.Ninject;
   

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var _kernel = new StandardKernel();
            try
            {
                _kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                _kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(_kernel);
                return _kernel;
            }
            catch
            {
                _kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel _kernel)
        {
  
            _kernel.Bind<ICampaignService>().To<CampaignService>();
            _kernel.Bind<ICategoryService>().To<CategoryService>();
            _kernel.Bind<ICategoryTypeService>().To<CategoryTypeService>();
            _kernel.Bind<ICommentService>().To<CommentService>();
            _kernel.Bind<ICookService>().To<CookService>();
            _kernel.Bind<IMessageService>().To<MessageService>();
            _kernel.Bind<IOrderService>().To<OrderService>();
            _kernel.Bind<IPaymentService>().To<PaymentService>();
            _kernel.Bind<IProductOrderDetailService>().To<ProductOrderDetailService>();
            _kernel.Bind<IProductOrderService>().To<ProductOrderService>();
            _kernel.Bind<IProductService>().To<ProductService>();
            _kernel.Bind<IRecipeService>().To<RecipeService>();
            _kernel.Bind<IRestaurantService>().To<RestaurantService>();
            _kernel.Bind<IScoringService>().To<ScoringService>();
            _kernel.Bind<ISharedService>().To<SharedService>();
            _kernel.Bind<IStockService>().To<StockService>();
            _kernel.Bind<ISupplierService>().To<SupplierService>();
            _kernel.Bind<IUserService>().To<UserService>();
            _kernel.Bind<IUserTypeService>().To<UserTypeService>();
            _kernel.Bind<IUnitAndProductService>().To<UnitAndProductService>();
            _kernel.Bind<IUnitOfProductService>().To<UnitOfProductService>();

            _kernel.Load<CustomDALModule>();
        }
    }
}