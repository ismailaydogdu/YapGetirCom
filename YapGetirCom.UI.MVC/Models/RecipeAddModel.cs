using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Models
{
    public class RecipeAddModel
    {
        public UnitAndProduct UnitAndProduct { get; set; }
        public Category Category { get; set; }
        public Recipe Recipe { get; set; }
    }
}