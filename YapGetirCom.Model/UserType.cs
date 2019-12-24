using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }
        public int UserTypeID { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
