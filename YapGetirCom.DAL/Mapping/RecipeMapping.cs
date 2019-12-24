using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class RecipeMapping : EntityTypeConfiguration<Recipe>
    {
        public RecipeMapping()
        {
            Property(x => x.RecipeName)
                .IsRequired()
                .HasMaxLength(30);

            Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
