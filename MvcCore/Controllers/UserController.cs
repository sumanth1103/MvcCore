using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MvcCore.Controllers
{
    public partial class UserController : Controller
    {
        public IActionResult Welcome()//Home
        {
            return View();
        }
        public IActionResult Index()//Register
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User u)
        {
            using(UserContext uc = new UserContext())
            {
                uc.Users.Add(u);
                uc.SaveChanges();
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            using (var context = new UserContext())
            {
                if (context.Users.Where(x => x.Name == login.Name && x.Password == login.Password).Count() > 0)
                {

                    //ViewBag.Name = login.Name;
                    TempData["Name"] = login.Name;
                    TempData.Keep("Name");
                    //Session["key"] = 2;
                    //HttpContext.Session.SetString("UserName", login.Name);
                    //return RedirectToAction("/LoginPage/HomePage");
                    return Redirect("/LoginPage/HomePage");
                }
                else
                {
                    return View();
                }
            }
        }
    }
}
