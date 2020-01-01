using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
   public class Order : BaseModel, IEntity
    {
        public int OrderID { get; set; }
        public int RecipeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequestedDate { get; set; }
        public int PaymentID { get; set; }
        public string Address { get; set; }
        public string OrderStatus { get; set; }
        public int RestaurantID { get; set; }
        public int CookID { get; set; }
        public int UserID { get; set; }
        public decimal OrderPrice { get; set; }
        public int Quantity { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Cook Cook { get; set; }
        public virtual User User { get; set; }

    }
}
