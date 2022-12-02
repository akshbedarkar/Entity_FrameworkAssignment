using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using FootBallLeague.Models;
namespace FootBallLeague.Controllers
{
    public class HomeController : Controller
    {
        FootBallLeagueContext obj=new FootBallLeagueContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = obj.FootBallLeague.ToList();
            return View(data);
        }

        
        public ActionResult Create() 
        {
            
            return View();

        }
        [HttpPost]
        public ActionResult Create(FootBallLeague.Models.FootBallLeague f)
        {
            obj.FootBallLeague.Add(f);
            obj.SaveChanges();

            return RedirectToAction("Index");

        }



        public ActionResult Display()
        {
            obj.FootBallLeague.ToList();
            
            obj.SaveChanges();
            return View("Index");
        }




    }
}