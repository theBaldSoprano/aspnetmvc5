using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.siski = hour < 12 ? "good morning" : "good afternoon";
            ViewBag.temp = "here is the new temporary";
            return View();
        }
        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}