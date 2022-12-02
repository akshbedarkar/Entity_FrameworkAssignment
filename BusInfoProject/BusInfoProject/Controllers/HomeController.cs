using BusInfoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusInfoProject.Controllers
{
    public class HomeController : Controller
    {
        DataContext1 obj = new DataContext1();
        public ActionResult Index()
        {
            var data = obj.BusInfoes.ToList();
            return View(data);
        }

        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create(BusInfoProject.Models.BusInfo b)
        //{
        //    obj.BusInfoes.Add(b);
        //    obj.SaveChanges();
        //    return RedirectToAction("Index");
        //}


        

    }
}