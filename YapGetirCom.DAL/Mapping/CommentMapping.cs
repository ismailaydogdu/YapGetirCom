using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class CommentMapping : EntityTypeConfiguration<Comment>
    {
        public CommentMapping()
        {
            Property(x => x.CommentContent)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
