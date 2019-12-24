using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class Stock
    {
        public int StockID { get; set; }
        public int SupplierID { get; set; }
        public int RestaurantID { get; set; }
        public bool isExistStock { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual Restaurant Restaurant { get; set; }

    }
}
