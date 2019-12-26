using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class CategoryType : BaseModel, IEntity
    {
        public CategoryType()
        {
            Categories = new HashSet<Category>();
        }
        public int CategoryTypeID { get; set; }
        public string CategoryTypeName { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

    }
}
