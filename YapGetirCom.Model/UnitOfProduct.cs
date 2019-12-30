using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class UnitOfProduct : IEntity
    {
        public UnitOfProduct()
        {
            UnitAndProducts = new List<UnitAndProduct>();
        }
        public int UnitOfProductID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UnitAndProduct> UnitAndProducts { get; set; }
    }
}
