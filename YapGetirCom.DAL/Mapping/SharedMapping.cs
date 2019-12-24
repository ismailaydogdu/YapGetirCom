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
        }
    }
}
