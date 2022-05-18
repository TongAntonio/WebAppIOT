using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppIOT.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppIOT.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckLogin(Login login)
        {
            if (login.Username == "admin" && login.Password == "1234")
            {
                return RedirectToAction("Index", "Menu");
            }
            else
            {
                return View();
            }
        }
    }
}
