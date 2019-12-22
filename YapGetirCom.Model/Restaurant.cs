using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class Restaurant : BaseModel
    {
        public Restaurant()
        {
            Cooks = new HashSet<Cook>();
            Comments = new HashSet<Comment>();
            Campaigns = new HashSet<Campaign>();
        }
        public int RestaurantID { get; set; }
        public string CompanyName { get; set; }
        public int CategoryID { get; set; }
        public bool IsFavourite { get; set; }
        public bool ControlInStock { get; set; }
        public int? ScoringID { get; set; }
        public virtual Category Category { get; set; }
        public virtual Scoring Scoring { get; set; }
        public virtual ICollection<Cook> Cooks { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Campaign> Campaigns { get; set; }



    }
}
