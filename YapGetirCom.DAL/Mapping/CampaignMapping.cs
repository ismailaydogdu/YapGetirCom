using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class CampaignMapping : EntityTypeConfiguration<Campaign>
    {
        public CampaignMapping()
        {
            Property(x => x.CampaignName)
                .HasMaxLength(30)
                .IsRequired();
            Property(x => x.CampaignStartTime)
                .HasColumnType("date");
            Property(x => x.CampaignFinishTime)
                .HasColumnType("date");



        }
    }
}
