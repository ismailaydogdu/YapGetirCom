﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class Restaurant : BaseModel, IEntity
    {
        public Restaurant()
        {
            Cooks = new HashSet<Cook>();
            Comments = new HashSet<Comment>();
            Campaigns = new HashSet<Campaign>();
            Stocks = new HashSet<Stock>();
            ProductOrders = new HashSet<ProductOrder>();
            Orders = new HashSet<Order>();
            Scorings = new HashSet<Scoring>();
            Shareds = new HashSet<Shared>();
        }
        public int RestaurantID { get; set; }
        public string CompanyName { get; set; }
        public int CategoryID { get; set; }
        public bool IsFavourite { get; set; }
        public int UserID { get; set; }
        public string Image { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Cook> Cooks { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Campaign> Campaigns { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Scoring> Scorings { get; set; }
        public virtual ICollection<Shared> Shareds { get; set; }
    }
}
