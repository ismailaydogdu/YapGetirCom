using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class ScoringMapping : EntityTypeConfiguration<Scoring>
    {
        public ScoringMapping()
        {
            Property(x => x.ScoringType)
                .IsRequired()
                .HasMaxLength(30);
        }

    }
}
