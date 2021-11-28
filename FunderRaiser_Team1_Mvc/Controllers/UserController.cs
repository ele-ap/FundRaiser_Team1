using Microsoft.AspNetCore.Mvc;


namespace FunderRaiser_Team1_Mvc.Controllers
{
    public class UserController : Controller
    {
        //private IUserService userService;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateUser()
        {
            return View();
        }
    }
}
