using Asp.Net.MVC.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
namespace Asp.Net.MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Signin()
        {
            return View();
        }
        LoginContext db = new LoginContext();
        [HttpPost]
        public ActionResult Signin(Models.Login user)
        {
            var username = db.Logins.FirstOrDefault(c => c.UserName == user.UserName && c.Password == user.Password);
            if (username != null)
            {
                FormsAuthentication.SetAuthCookie(username.UserName, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mesaj = "Password or password is incorrect";
                return View();
            }
        }
    }
}