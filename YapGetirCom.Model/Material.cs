using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
   public class Material : BaseModel, IEntity
    {
        public Material()
        {
            Recipes = new HashSet<Recipe>();
        }
        public int MaterialID { get; set; }
        public int ProductID { get; set; }
        public string MaterialMeasurement { get; set; }
        public decimal MaterialAmount { get; set; }
        public decimal MaterialPrice { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual Product Product { get; set; }
    }
}
