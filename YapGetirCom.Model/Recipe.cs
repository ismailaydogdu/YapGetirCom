using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class Recipe : BaseModel
    {
        public Recipe()
        {
            Comments = new HashSet<Comment>();
            Materials = new HashSet<Material>();
            Shareds = new HashSet<Shared>();
        }
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public bool IsFavourite { get; set; }
        public int ScoringID { get; set; }

        public virtual Category Category { get; set; }
        public virtual Scoring Scoring { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<Shared> Shareds { get; set; }
    }
}
