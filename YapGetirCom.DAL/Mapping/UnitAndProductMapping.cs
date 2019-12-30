using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class UnitAndProductMapping: EntityTypeConfiguration<UnitAndProduct>
    {
        public UnitAndProductMapping()
        {
            HasRequired(x => x.Product)
                .WithMany(x => x.UnitAndProducts)
                .HasForeignKey(x => x.ProductID);

            HasRequired(x => x.UnitOfProduct)
                .WithMany(x => x.UnitAndProducts)
                .HasForeignKey(x => x.UnitOfProductID);
        }
    }
}
