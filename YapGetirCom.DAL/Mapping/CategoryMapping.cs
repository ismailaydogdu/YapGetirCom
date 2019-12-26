using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            Property(x => x.CategoryName)
                .HasMaxLength(30)
                .IsRequired();


            HasRequired(x => x.CategoryType)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.CategoryTypeID);
        }
    }
}
