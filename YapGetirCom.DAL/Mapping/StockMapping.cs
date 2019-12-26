using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class StockMapping : EntityTypeConfiguration<Stock>
    {
        public StockMapping()
        {

            HasRequired(a => a.Supplier)
              .WithMany(a => a.Stocks)
              .HasForeignKey(a => a.SupplierID);

            HasRequired(a => a.Restaurant)
              .WithMany(a => a.Stocks)
              .HasForeignKey(a => a.RestaurantID);
        }
    }
}
