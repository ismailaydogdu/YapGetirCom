using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class MessageMapping : EntityTypeConfiguration<Message>
    {
        public MessageMapping()
        {
            Property(x => x.Content)
                .HasMaxLength(500);
        }
    }
}
