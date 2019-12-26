using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class SharedMapping : EntityTypeConfiguration<Shared>
    {
        public SharedMapping()
        {
            Property(x => x.SharedType)
                .HasMaxLength(30)
                .IsRequired();


            HasRequired(x => x.Restaurant)
               .WithMany(x => x.Shareds)
               .HasForeignKey(x => x.RestaurantID);

            HasRequired(x => x.Cook)
              .WithMany(x => x.Shareds)
              .HasForeignKey(x => x.CookID);

            HasRequired(x => x.Recipe)
              .WithMany(x => x.Shareds)
              .HasForeignKey(x => x.RecipeID);

            HasRequired(x => x.User)
                 .WithMany(x => x.Shareds)
                 .HasForeignKey(x => x.UserID);
        }
              
    }
}
