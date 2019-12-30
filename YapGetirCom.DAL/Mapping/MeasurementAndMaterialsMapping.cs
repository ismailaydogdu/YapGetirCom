using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class MeasurementAndMaterialsMapping : EntityTypeConfiguration<UnitAndProduct>
    {
        public MeasurementAndMaterialsMapping()
        {
            Property(x => x.Price)
                .HasColumnType("money");

        }
    }
}
