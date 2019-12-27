using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using YapGetirCom.DAL.Repositories.Abstract;
using YapGetirCom.DAL.Repositories.Concrete;
using YapGetirCom.Model;

namespace YapGetirCom.BLL.IoC.Ninject
{
    public class CustomDALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICampaignRepository>().To<CampaignRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<ICategoryTypeRepository>().To<CategoryTypeRepository>();
            Bind<ICommentRepository>().To<CommentRepository>();
            Bind<ICookRepository>().To<CookRepository>();
            Bind<IMaterialRepository>().To<MaterialRepository>();
            Bind<IMessageRepository>().To<MessageRepository>();
            Bind<IOrderRepository>().To<OrderRepository>();
            Bind<IPaymentRepository>().To<PaymentRepository>();
            Bind<IProductOrderDetailRepository>().To<ProductOrderDetailRepository>();
            Bind<IProductOrderRepository>().To<ProductOrderRepository>();
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IRecipeRepository>().To<RecipeRepository>();
            Bind<IRestaurantRepository>().To<RestaurantRepository>();
            Bind<IScoringRepository>().To<ScoringRepository>();
            Bind<ISharedRepository>().To<SharedRepository>();
            Bind<IStockRepository>().To<StockRepository>();
            Bind<ISupplierRepository>().To<SupplierRepository>();
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IUserTypeRepository>().To<UserTypeRepository>();

        }
    }
}
