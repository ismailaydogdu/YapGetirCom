using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Models
{
    public class HomeVM
    {
        public HomeVM()
        {
            Restaurants = new List<Restaurant>();
            Recipes = new List<Recipe>();
        }
        public List<Restaurant> Restaurants { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}