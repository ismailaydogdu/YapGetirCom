﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.Entity;

namespace YapGetirCom.Model
{
    public class Comment : BaseModel, IEntity
    {
        public int CommentID { get; set; }
        public string CommentContent { get; set; }
        public int? RestaurantID { get; set; }
        public int? RecipeID { get; set; }
        public int? CookID { get; set; }
        public int? UserID { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual Cook Cook { get; set; }
        public virtual User User { get; set; }

    }
}
