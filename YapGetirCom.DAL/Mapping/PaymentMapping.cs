using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class PaymentMapping : EntityTypeConfiguration<Payment>
    {
        public PaymentMapping()
        {
            Property(x => x.PaymentType)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
