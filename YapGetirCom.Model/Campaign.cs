using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class Campaign : BaseModel, IEntity
    {
        public Campaign()
        {
            Users = new HashSet<User>();
            Restaurants = new HashSet<Restaurant>();
            Recipes = new HashSet<Recipe>();
        }
        public int CampaignID { get; set; }
        public string CampaignName { get; set; }
        public DateTime CampaignStartTime { get; set; }
        public DateTime CampaignFinishTime { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
