using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HolidayMVC.Models;

namespace HolidayMVC.Controllers
{
    public class HolidayController : Controller
    {
        
        // GET: Holiday
        public ActionResult Index()
        {
            Random rand = new Random();
            Holiday h = new Holiday();
            switch (rand.Next(3))
            {
                case 0:                    
                    h.Name = "Queens Birthday";
                    h.Date = new DateTime(2016, 6, 6);
                    h.ImageFile = "queen.jpg";
                    break;
                case 1:
                    h.Name = "Halloween";
                    h.Date = new DateTime(2016, 10, 31);
                    h.ImageFile = "halloween.jpg";
                    break;
                case 2:
                    h.Name = "Boxing Day";
                    h.Date = new DateTime(2016, 12, 26);
                    h.ImageFile = "boxing.jpg";
                    break;
            }
            ViewBag.Name = h.Name;
            ViewBag.Days = (int)(h.Date - DateTime.Now).TotalDays;
            ViewBag.Image = h.ImageFile; 
            return View();
        }
    }
}