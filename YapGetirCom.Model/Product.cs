using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class Product : BaseModel
    {
        public Product()
        {
           
            Campaigns = new HashSet<Campaign>();
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public decimal Price { get; set; }
        
        public Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        
        public virtual ICollection<Campaign> Campaigns { get; set; }

    }
}
