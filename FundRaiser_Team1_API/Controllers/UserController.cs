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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<UserDto>> GetUserById(int id)
        {
            var dto = await _userService.GetUserById(id);
            if (dto == null) return NotFound("Invalid id.");
            return Ok(dto);
        }

    }
}
