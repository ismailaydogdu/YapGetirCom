using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class ProductMapping:EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            Property(x => x.ProductName)
                .HasMaxLength(25)
                .IsRequired();

            Property(x => x.Price)
                .HasColumnType("money");
        }
    }
}
