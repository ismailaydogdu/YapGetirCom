using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class ProductOrder:BaseModel, IEntity
    {
        public ProductOrder()
        {
            ProductOrderDetails = new HashSet<ProductOrderDetail>();
        }
        public int ProductOrderID { get; set; }
        public int SupplierID { get; set; }
        public int RestaurantID { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<ProductOrderDetail> ProductOrderDetails { get; set; }
    }
}
