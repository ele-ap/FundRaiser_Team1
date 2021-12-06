using FundRaiser_Team1.Models;
using FundRaiser_Team1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_Mvc.Controllers
{
    public class PackageController : Controller
    {
        private readonly IPackageService _packageService;

        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePackage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePackage(Package package)
        {
            _packageService.CreatePackage(package);

            return RedirectToAction(nameof(Index));
        }
    }
}
