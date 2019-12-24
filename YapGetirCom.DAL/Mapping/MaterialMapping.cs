using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class MaterialMapping : EntityTypeConfiguration<Material>
    {
        public MaterialMapping()
        {
      
            Property(x => x.MaterialMeasurement)
                .IsRequired()
                .HasMaxLength(50);
            Property(x => x.MaterialPrice)
                .HasColumnType("money");
        }
    }
}
