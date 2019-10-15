using HospitalAppointmentSystem.Models;
using HospitalAppointmentSystem.Models.ModelFactory;
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
            return View("MainPage");

        }
        [HttpPost]
        public ActionResult Register(UserForRegister user)
        {
            HASDatabase _context = new HASDatabase();

            _context.Patient.Add(new Patient()
            {
                Id = user.Id,
                age = user.age,
                bloodGroup = user.bloodGroup,
                email = user.email,
                gender = user.gender,
                name = user.name,
                surname = user.surname,
                password = user.password,
                telephone = user.telephone,
                isDeleted = false,
                isAdmin = user.Id == 10101010 ? true : false,
                deletingTime = DateTime.Now

            });
            _context.SaveChanges();
            return View();
        }
    }
}