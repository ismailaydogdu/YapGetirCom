using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class Cook : BaseModel
    {
        public Cook()
        {
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
            Scorings = new HashSet<Scoring>();
            Shareds = new HashSet<Shared>();
        }
        public int CookID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RestaurantID { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Scoring> Scorings { get; set; }
        public virtual ICollection<Shared> Shareds { get; set; }
    }
}
