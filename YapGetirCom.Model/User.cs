using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class User : BaseModel
    {
        public User()
        {
            Suppliers = new HashSet<Supplier>();
            Products = new HashSet<Product>();
            Comments = new HashSet<Comment>();
        }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Region { get; set; }
        public DateTime BirthDate { get; set; }
        public int UserTypeID { get; set; }                     
        public virtual ICollection<Supplier>  Suppliers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
