using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.BLL.Abstract;

namespace YapGetirCom.BLL
{
    public interface IUnitOfWorkService
    {
        ICampaignService CampaignService { get; }
        ICategoryService CategoryService { get; }
        ICategoryTypeService CategoryTypeService { get; }
        ICommentService CommentService { get; }
        ICookService CookService { get; }
        IMessageService MessageService { get; }
        IOrderService OrderService { get; }
        IPaymentService PaymentService { get; }
        IProductOrderDetailService ProductOrderDetailService { get; }
        IProductOrderService ProductOrderService { get; }
        IProductService ProductService { get; }
        IRecipeService RecipeService { get; }
        IRestaurantService RestaurantService { get; }
        IScoringService ScoringService { get; }
        ISharedService SharedService { get; }
        IStockService StockService { get; }
        ISupplierService SupplierService { get; }
        IUserService UserService { get; }
        IUserTypeService UserTypeService { get; }
        void Complete();
        void Dispose();
    }
}
