using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class OrderMapping : EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            Property(x => x.OrderDate)
                .IsRequired()
                .HasColumnType("date");

            

            Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.OrderStatus)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.OrderPrice)
                .IsRequired()
                .HasColumnType("money");
        }
    }
}
