using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class Supplier : BaseModel, IEntity
    {
        public Supplier()
        {
            Stocks = new HashSet<Stock>();
            ProductOrders = new HashSet<ProductOrder>();
            Products = new HashSet<Product>();
        }
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
