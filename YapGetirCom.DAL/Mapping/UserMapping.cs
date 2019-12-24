using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            Property(x => x.FirstName)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.LastName)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.EMail)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Password)
                 .HasMaxLength(30)
                 .IsRequired();

            Property(x => x.Region)
                .HasMaxLength(30)
                .IsRequired();

            Property(x => x.BirthDate)
                .HasColumnType("date");

        }
    }
}
