using HospitalAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalAppointmentSystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HASDatabase _context = new HASDatabase();
            _context.City.Add(new City() { name = "ASD" });
            return View("MainPage");

        }
    }
}