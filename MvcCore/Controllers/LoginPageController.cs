using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcCore.Controllers
{
    public class LoginPageController : Controller
    {
        public IActionResult HomePage(string name)
        {
           // ViewBag.UserName = HttpContext.Session.GetString("UserName");
            var context = new UserContext();
            List<User> data = context.Users.ToList();
            foreach(var i in data)
            {
                
                if(i.Name == name)
                {
                    List<string> l = new List<string>();
                    l.Add(i.Name);
                    l.Add(i.Email);
                    return View(l);
                }
            }
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        
    }
}
