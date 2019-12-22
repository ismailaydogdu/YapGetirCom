using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class Campaign: BaseModel
    {
        public Campaign()
        {
            Products = new HashSet<Product>();
        }
        public int CampaignID { get; set; }
        public string CampaignName { get; set; }
        public DateTime CampaignStartTime { get; set; }
        public DateTime CampaignFinishTime { get; set; }
        public int ProductID { get; set; }
        public int RestaurantID { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual Restaurant Restaurant { get; set; }

    }
}
