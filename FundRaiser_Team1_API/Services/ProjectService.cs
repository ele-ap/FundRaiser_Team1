using FundRaiser_Team1.Models;
using FundRaiser_Team1_API.DTO;
using FundRaiser_Team1_API.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_API.Services
{
    public class ProjectService : IProjectService
    {
        private readonly FundRaiserDbContext _db;
        public ProjectService(FundRaiserDbContext db)
        {
            _db = db;
        }
        public Task<ProjectDto> CreateProject(ProjectDto project)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProjectDto>> GetAllProjects()
        {
            return await _db.Projects
                .Select(p => new ProjectDto()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Description = p.Description,
                    StatusPost = p.StatusPost
                })
                .ToListAsync();
        }

        public UserDto GetCreator()
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetFunders()
        {
            throw new NotImplementedException();
        }

        public async Task<ProjectDto> GetProject(int id)
        {
            var project = await _db.Projects.Include(b=>b.Users).SingleOrDefaultAsync(b => b.Id == id);
                
            if (project is null) return null;

            return new ProjectDto() {
                Id = project.Id,
                Title = project.Title,
                Description = project.Description,
                StatusPost = project.StatusPost,
            };
        }
    }
}
