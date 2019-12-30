using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class UnitAndProductRecipe:IEntity
    {

        public int UnitAndProductRecipeID { get; set; }
        public int UnitAndProductID { get; set; }
        public int RecipeID { get; set; }
        public int Quantity { get; set; }

        public virtual UnitAndProduct UnitAndProduct { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
