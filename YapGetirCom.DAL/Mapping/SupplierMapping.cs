using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class SupplierMapping : EntityTypeConfiguration<Supplier>
    {
        public SupplierMapping()
        {
            Property(x => x.CompanyName)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.City)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Country)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Phone)
                .IsRequired()
                .HasMaxLength(24);
        }
    }
}
