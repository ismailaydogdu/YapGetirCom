using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.DAL.Repositories.Abstract;
using YapGetirCom.DAL.Repositories.Concrete;
using YapGetirCom.Model;

namespace YapGetirCom.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private YapGetirComDbContext _db;

        public UnitOfWork(YapGetirComDbContext db)
        {
            _db = db;

            CampaignRepository = new CampaignRepository(_db);
            CategoryRepository = new CategoryRepository(_db);
            CategoryTypeRepository = new CategoryTypeRepository(_db);
            CommentRepository = new CommentRepository(_db);
            CookRepository = new CookRepository(_db);
            MessageRepository = new MessageRepository(_db);
            OrderRepository = new OrderRepository(_db);
            PaymentRepository = new PaymentRepository(_db);
            ProductOrderDetailRepository = new ProductOrderDetailRepository(_db);
            ProductOrderRepository = new ProductOrderRepository(_db);
            ProductRepository = new ProductRepository(_db);
            RecipeRepository = new RecipeRepository(_db);
            RestaurantRepository = new RestaurantRepository(_db);
            ScoringRepository = new ScoringRepository(_db);
            SharedRepository = new SharedRepository(_db);
            StockRepository = new StockRepository(_db);
            SupplierRepository = new SupplierRepository(_db);
            UserRepository = new UserRepository(_db);
            UserTypeRepository = new UserTypeRepository(_db);
        }
        public ICampaignRepository CampaignRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public ICategoryTypeRepository CategoryTypeRepository { get; private set; }
        public ICommentRepository CommentRepository { get; private set; }
        public ICookRepository CookRepository { get; private set; }
        public IMessageRepository MessageRepository { get; private set; }
        public IOrderRepository OrderRepository { get; private set; }
        public IPaymentRepository PaymentRepository { get; private set; }
        public IProductOrderDetailRepository ProductOrderDetailRepository { get; private set; }
        public IProductOrderRepository ProductOrderRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public IRecipeRepository RecipeRepository { get; private set; }
        public IRestaurantRepository RestaurantRepository { get; private set; }
        public IScoringRepository ScoringRepository { get; private set; }
        public ISharedRepository SharedRepository { get; private set; }
        public IStockRepository StockRepository { get; private set; }
        public ISupplierRepository SupplierRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        public IUserTypeRepository UserTypeRepository { get; private set; }
        public int Complete()
        {
            return _db.SaveChanges();
        }
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
