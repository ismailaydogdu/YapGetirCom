﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetirCom.Model
{
    public class Supplier : BaseModel
    {
        public Supplier()
        {
            Users = new HashSet<User>();
        }
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
