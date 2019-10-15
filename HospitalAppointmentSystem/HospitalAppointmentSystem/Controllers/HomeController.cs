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

        [HttpPost]
        public ActionResult Signin (UserForSignin user)
        {
            using (HASDatabase db = new HASDatabase())
            {
                var userDetail = db.Patient.Where(x => x.Id == user.Id && x.password == user.password).FirstOrDefault();
                if(userDetail == null)
                {
                    user.SigninErrorMsg = "Invalid TC Identity Number or Password!";
                    return View("Index", user);
                }
                else
                {
                    Session["userID"] = user.Id;
                    return RedirectToAction("Index", "Home");
                }
            }
            

        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        
    }
}