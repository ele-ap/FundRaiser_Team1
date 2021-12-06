using FundRaiser_Team1.Models;
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
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<List<ProjectDto>> GetAllProjects()
        {
            return await _projectService.GetAllProjects();
        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<ProjectDto>> GetProjectById(int id)
        {
            var dto = await _projectService.GetProject(id);
            if (dto == null) return NotFound("Invalid id.");
            return Ok(dto);
        }

        [HttpDelete, Route("{id}")]
        public async Task<ActionResult<bool>> DeleteProject(int id)
        {
            return await _projectService.DeleteProject(id);
        }
    }
}
