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

        public UserDto GetCreator(int projectId)
        {
            var user = _db.Set<ProjectUser>()
                .Where(p => p.ProjectId == projectId && p.Category == Category.CREATOR)
                .SingleOrDefault();

            var my_user = ReadUser(user.UserId);

            return new UserDto
            {
                FirstName = my_user.FirstName,
                Id = my_user.Id,
                LastName = my_user.LastName,
            };
        }

        public List<UserDto> GetFunders(int projectId)
        {
            var usr_dto = new List<UserDto>();
            var user = _db.Set<ProjectUser>()
                .Where(p => p.ProjectId == projectId && p.Category == Category.BACKER)
                .ToList();

            foreach (var usr in user)
            {
                var my_user = ReadUser(usr.UserId);

                usr_dto.Add(
                    new UserDto { 
                         FirstName = my_user.FirstName,
                         LastName = my_user.LastName
                    });
            }

            return usr_dto;
        }

        public User ReadUser(int id)
        {
            User user = _db.User.Find(id);
            return user;
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

        public async Task<bool> DeleteProject(int id)
        {
            Project project = await _db.Projects
                .SingleOrDefaultAsync(p => p.Id == id);
            _db.Remove(project);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
