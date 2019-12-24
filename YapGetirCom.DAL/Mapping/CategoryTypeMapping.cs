using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{

    class CategoryTypeMapping : EntityTypeConfiguration<CategoryType>
    {
        public CategoryTypeMapping()
        {
            Property(x => x.CategoryTypeName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
