using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_21.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(
            string firstName = "",
            string lastName = "",
            string email = "",
            int number = 0,
            string password = "",
            int cupsDay = 0,
            string strength = "")
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = email;
            ViewBag.Number = number;
            ViewBag.Password = password;
            ViewBag.CupsDay = cupsDay;
            ViewBag.Strength = strength;
            return View();
        }
    }
}