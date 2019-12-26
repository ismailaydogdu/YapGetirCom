using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class ProductOrderMapping : EntityTypeConfiguration<ProductOrder>
    {
        public ProductOrderMapping()
        {
            HasRequired(x => x.Supplier)
                .WithMany(x => x.ProductOrders)
                .HasForeignKey(x => x.SupplierID);




        }
    }
}
