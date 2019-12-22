using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class Scoring : BaseModel
    {
        public Scoring()
        {
            Restaurants = new HashSet<Restaurant>();
            Cooks = new HashSet<Cook>();
            Recipes = new HashSet<Recipe>();
        }
        public int ScoringID { get; set; }
        public string ScoringType { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }
        public virtual ICollection<Cook> Cooks { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
