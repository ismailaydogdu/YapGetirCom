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
        }
        public int CookID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RestaurantID { get; set; }
        public int ScoringID { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Scoring Scoring { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
