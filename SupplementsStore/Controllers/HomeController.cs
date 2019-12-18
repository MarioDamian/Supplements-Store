using SupplementsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupplementsStore.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Article");
            }

            var articles = (from article in db.Articles
                            select article);

            ViewBag.FirstArticle = articles.FirstOrDefault();
            ViewBag.Articles = articles.OrderBy(o => o.Date).Skip(1).Take(2);

            return View();
        }
    }
}