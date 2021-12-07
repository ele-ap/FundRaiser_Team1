using FundRaiser_Team1_API.DTO;
using FundRaiser_Team1_API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IPackageService _userService;

        public PackageController(IPackageService userService)
        {
            _userService = userService;
        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<PackageDto>> GetUserById(int id)
        {
            var dto = await _userService.GetPackageById(id);
            if (dto == null) return NotFound("Cannot find package with this id.");
            return Ok(dto);
        }
    }
}
