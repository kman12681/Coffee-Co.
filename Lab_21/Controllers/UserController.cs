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
            string firstName = "John",
            string lastName = "Smith",
            string email = "John@Smith.com",
            int number = 0000000000,
            string password = "password",
            string birthday = "",
            string strength = "medium")
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = email;
            ViewBag.Number = number;
            ViewBag.Password = password;
            ViewBag.Birthday = birthday;
            ViewBag.Strength = strength;
            return View();
        }
    }
}