using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class UserTypeMapping : EntityTypeConfiguration<UserType>
    {
        public UserTypeMapping()
        {
            Property(x => x.TypeName)
                .HasMaxLength(25);
        }
    }
}
