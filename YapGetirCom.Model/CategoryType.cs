using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class CategoryType : BaseModel
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
