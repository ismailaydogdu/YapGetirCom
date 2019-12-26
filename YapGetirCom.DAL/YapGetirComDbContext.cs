using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.DAL.Mapping;
using YapGetirCom.Model;

namespace YapGetirCom.DAL
{
    public class YapGetirComDbContext : DbContext
    {
        public YapGetirComDbContext() : base("Server=.; Database=YapGetirComDb; uid=sa; pwd=123")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new CampaignMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new CookMapping());
            modelBuilder.Configurations.Add(new MaterialMapping());
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new PaymentMapping());
            modelBuilder.Configurations.Add(new RecipeMapping());
            modelBuilder.Configurations.Add(new RestaurantMapping());
            modelBuilder.Configurations.Add(new ScoringMapping());
            modelBuilder.Configurations.Add(new SharedMapping());
            modelBuilder.Configurations.Add(new SupplierMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new UserTypeMapping());
            modelBuilder.Configurations.Add(new CategoryTypeMapping());

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Shared> Shareds { get; set; }
        public DbSet<Scoring> Scorings { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Payment> Prices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Cook> Cooks { get; set; }
        public DbSet<Comment> GetComments { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<ProductOrderDetail> ProductOrderDetails { get; set; }


    }
}
