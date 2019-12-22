using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class RestaurantMapping : EntityTypeConfiguration<Restaurant>
    {
        public RestaurantMapping()
        {
            Property(x => x.CompanyName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
