using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
   public class Material : BaseModel
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

        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual Product Product { get; set; }
    }
}
