using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Mapping
{
    class ProductOrderDetailMapping : EntityTypeConfiguration<ProductOrderDetail>
    {
        public ProductOrderDetailMapping()
        {
            HasRequired(x => x.Product)
                .WithMany(x => x.ProductOrderDetails);
        }
    }
}
