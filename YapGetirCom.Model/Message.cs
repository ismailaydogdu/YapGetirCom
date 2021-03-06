﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class Message:BaseModel, IEntity
    {
        public int MessageID { get; set; }
        public int UserID { get; set; }
        public int RestaurantID { get; set; }
        public string Content { get; set; }
        public bool IsSenderUser { get; set; }

        public User User { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
