using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class Recipe : BaseModel, IEntity
    {
        public Recipe()
        {
            Comments = new HashSet<Comment>();
            Materials = new HashSet<Material>();
            Campaigns = new HashSet<Campaign>();
            Orders = new HashSet<Order>();
            Scorings = new HashSet<Scoring>();
            Shareds = new HashSet<Shared>();
        }
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public bool IsFavourite { get; set; }
        public int UserID { get; set; }
        public string Image { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<Campaign> Campaigns { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Scoring> Scorings { get; set; }
        public virtual ICollection<Shared> Shareds { get; set; }
    }
}
