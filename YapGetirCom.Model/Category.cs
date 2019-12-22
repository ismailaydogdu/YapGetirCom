using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class Category : BaseModel
    {
        public Category()
        {
            Restaurants = new HashSet<Restaurant>();
            Products = new HashSet<Product>();
            Recipes = new HashSet<Recipe>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int CategoryTypeID { get; set; }
        public virtual CategoryType CategoryType { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }

    }
}
