using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class ProductOrderDetail : IEntity
    {
        public int ProductOrderDetailID { get; set; }
        public int ProductOrderID { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual ProductOrder ProductOrder { get; set; }
        public virtual Product Product { get; set; }
    }
}
