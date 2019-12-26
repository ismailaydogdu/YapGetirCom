
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.DAL.Repositories.Abstract;

namespace YapGetirCom.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        ICampaignRepository CampaignRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ICategoryTypeRepository CategoryTypeRepository { get; }
        ICommentRepository CommentRepository { get; }
        ICookRepository CookRepository { get; }
        IMaterialRepository MaterialRepository { get; }
        IMessageRepository MessageRepository { get; }
        IOrderRepository OrderRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        IProductOrderDetailRepository ProductOrderDetailRepository { get; }
        IProductOrderRepository ProductOrderRepository { get; }
        IProductRepository ProductRepository { get; }
        IRecipeRepository RecipeRepository { get; }
        IRestaurantRepository RestaurantRepository { get; }
        IScoringRepository ScoringRepository { get; }
        ISharedRepository SharedRepository { get; }
        IStockRepository StockRepository { get; }
        ISupplierRepository SupplierRepository { get; }
        IUserRepository UserRepository { get; }
        IUserTypeRepository UserTypeRepository { get; }

        int Complete();
    }
}
