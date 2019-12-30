using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class UnitAndProduct : IEntity
    {
        public UnitAndProduct()
        {
            UnitAndProductRecipes = new HashSet<UnitAndProductRecipe>();
        }
        public int UnitAndProductID { get; set; }
        public int ProductID { get; set; }
        public int UnitOfProductID { get; set; }
        public decimal Price { get; set; }


        public virtual ICollection<UnitAndProductRecipe> UnitAndProductRecipes { get; set; }
        public virtual Product Product { get; set; }
        public virtual UnitOfProduct UnitOfProduct { get; set; }

    }
}
