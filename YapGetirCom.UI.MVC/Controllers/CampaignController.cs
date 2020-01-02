using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.UI.MVC.Controllers
{
    public class CampaignController : Controller
    {
        // GET: Campaign
        private ICampaignService _campaignService;

        public CampaignController(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
        public ActionResult Index()
        {
            List<Campaign> campaigns = _campaignService.GetAll().ToList();
            return View(campaigns);
        }
    }
}