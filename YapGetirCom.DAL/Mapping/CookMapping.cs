using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class CookMapping : EntityTypeConfiguration<Cook>
    {
        public CookMapping()
        {
            Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(30);

            HasRequired(x => x.Restaurant)
              .WithMany(x => x.Cooks)
              .HasForeignKey(x => x.RestaurantID);
        }
    }
}
