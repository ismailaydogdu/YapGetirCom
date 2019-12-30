using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class MeasurementUnitOfMaterialMapping : EntityTypeConfiguration<UnitOfProduct>
    {
        public MeasurementUnitOfMaterialMapping()
        {
            Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

           

        }
    }
}
