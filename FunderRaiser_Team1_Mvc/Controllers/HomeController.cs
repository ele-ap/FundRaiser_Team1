using FunderRaiser_Team1_Mvc.Models;
using FundRaiser_Team1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FunderRaiser_Team1_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }
      
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(String email,string password)
        {
            try
            {
                using (FundRaiserDbContext db = new FundRaiserDbContext())
                {
                    User u = (from user in db.User
                              where user.Email == email
                              select user).SingleOrDefault();

                    if (u != null)
                    {

                        if (password.Equals(u.Password))
                        {
                            return RedirectToAction(nameof(Index));
                        }
                        return View();
                    }
                }
            }
            catch
            {
                throw;
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
