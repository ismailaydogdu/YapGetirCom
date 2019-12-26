using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class Payment : BaseModel, IEntity
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }
        public int PaymentID { get; set; }
        public string PaymentType { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
