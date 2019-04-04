using Asp.Net.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net.MVC.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(string username, string Password1, string Emailtxt, string Password2)
        {
            using (var db = new LoginContext())
            {
                var log = new Login
                {
                    UserName = username,
                    Password = Password1,
                    Email = Emailtxt,
                    Id = 1,
                };
                if (log.Password == Password2)
                {
                    db.Logins.Add(log);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Mesaj = "Yanlış Parola Girdiniz";
                    return View();
                }
            }
        }
    }
}