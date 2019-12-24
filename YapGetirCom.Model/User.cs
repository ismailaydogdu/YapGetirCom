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
            Comments = new HashSet<Comment>();
            Restaurants = new HashSet<Restaurant>();
            Suppliers = new HashSet<Supplier>();
            Campaigns = new HashSet<Campaign>();
        }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Region { get; set; }
        public DateTime BirthDate { get; set; }
        public int UserTypeID { get; set; }                       
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<Campaign> Campaigns { get; set; }
    }
}
