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
        private readonly IPackageService _packageService;

        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<PackageDto>> GetPackageById(int id)
        {
            var dto = await _packageService.GetPackageById(id);
            if (dto == null) return NotFound("Cannot find package with this id.");
            return Ok(dto);
        }

        [HttpDelete, Route("delete/{id}")]
        public async Task<ActionResult<bool>> DeletePackage(int id)
        {
            var deleted = await _packageService.DeletePackage(id);
            if (!deleted) return NotFound("The package you are trying to delete does not exist.");
            return Ok(deleted);
        }

        [HttpPatch, Route("{id}")]
        public async Task<ActionResult<PackageDto>> UpdatePackage([FromRoute] int id, [FromBody] PackageDto dto)
        {
            var response = await _packageService.UpdatePackage(id, dto);
            if (response == null) return NotFound("The package you are trying to update does not exist.");
            return Ok(response);
        }
    }
}
