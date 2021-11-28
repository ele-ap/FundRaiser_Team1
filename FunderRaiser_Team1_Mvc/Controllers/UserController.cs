using Microsoft.AspNetCore.Mvc;
using FundRaiser_Team1.Models;
using FundRaiser_Team1.Services;

namespace FunderRaiser_Team1_Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            userService.CreateUser(user);

            return RedirectToAction(nameof(Index));
        }
    }
}
