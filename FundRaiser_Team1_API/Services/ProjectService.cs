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
            var projects = new List<Project>();
            var dto_list = new List<ProjectDto>();
            projects = await _db.Projects.Include(p => p.AwardPackages)               
                                         .ToListAsync();
            foreach(var p in projects)
            {
                var pckg_list = new List<PackageDto>();

                foreach (var pckg in p.AwardPackages)
                {
                    pckg_list.Add(new PackageDto() { 
                         PackageName = pckg.PackageName,
                         Description = pckg.Description,
                         PackagePrice = pckg.PackagePrice
                    });
                }

                dto_list.Add(new ProjectDto()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Description = p.Description,
                    StatusPost = p.StatusPost,
                    AwardPackages = pckg_list
                });              
            }

            return dto_list;
        }

        public UserDto GetCreator(int projectId)
        {
            var user = _db.Set<ProjectUser>()
                .Where(p => p.ProjectId == projectId && p.CategoryProject == Category.CREATOR)
                .SingleOrDefault();

            var my_user = _db.User.Find(user.UserId);

            return new UserDto
            {
                FirstName = my_user.FirstName,
                LastName = my_user.LastName,
            };
        }

        public List<UserDto> GetFunders(int projectId)
        {
            var usr_dto = new List<UserDto>();
            var user = _db.Set<ProjectUser>()
                .Where(p => p.ProjectId == projectId && p.CategoryProject == Category.BACKER)
                .ToList();

            foreach (var usr in user)
            {
                var my_user = _db.User.Find(usr.UserId);

                usr_dto.Add(
                    new UserDto { 
                         FirstName = my_user.FirstName,
                         LastName = my_user.LastName
                    });
            }

            return usr_dto;
        }

        public async Task<ProjectDto> GetProject(int id)
        {
            var award_packages = new List<PackageDto>();
            var project = await _db.Projects.Include(b=>b.AwardPackages).SingleOrDefaultAsync(b => b.Id == id);
                
            if (project is null) return null;

            foreach(var package in project.AwardPackages)
            {
                award_packages.Add(new PackageDto {
                     PackageName = package.PackageName,
                     Description = package.Description,
                     PackagePrice = package.PackagePrice
                });
            }

            return new ProjectDto() {
                Id = project.Id,
                Title = project.Title,
                Description = project.Description,
                StatusPost = project.StatusPost,
                AwardPackages = award_packages
            };
        }

        public async Task<bool> DeleteProject(int id)
        {
            Project project = await _db.Projects
                .SingleOrDefaultAsync(p => p.Id == id);
            if (project == null) return false;
            _db.Remove(project);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
