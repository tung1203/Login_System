using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private UserContext db = new UserContext();
        public IActionResult Index([FromQuery] string username)
        {
             ViewBag.users = db.Users.ToList();
             
            ViewBag.message = HttpContext.Session.GetString("username");
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username)
        {
            HttpContext.Session.SetString("username", username);
            return Redirect("/?name=" + username);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }
        public IActionResult Register()
        {
            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
