﻿using FundRaiser_Team1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{
    public class ProjectService : IProjectService
    {
        private readonly FundRaiserDbContext _dbContext;

        public ProjectService(FundRaiserDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Project CreateProject(Project project)
        {
            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
            return project;
        }

        public bool DeleteProject(int projectId)
        {
            var projectDb = _dbContext.Projects.Find(projectId);
            if (projectDb is null) return false;
            _dbContext.Projects.Remove(projectDb);

            return _dbContext.SaveChanges() == 1;
        }

        public List<User> GetBackers(int projectId)
        {
            var projectDb = _dbContext.Projects.Find(projectId);
            return projectDb.Users;
        }

        public User GetCreator(int projectId)
        {
            var projectDb = _dbContext.Projects.Find(projectId);
            return (User)projectDb.Users.Where(user => user.Category == Category.CREATOR);
        }

        public List<Package> GetPackages(int projectId)
        {
            var projectDb = _dbContext.Projects.Find(projectId);
            return projectDb.AwardPackages;
        }

        public List<Project> GetAllProjects()
        {
            return _dbContext.Projects.ToList();
        }

        public Project GetProject(int projectId)
        {
            var projectDb = _dbContext.Projects.Include(project => project.Users)
                                               .FirstOrDefault(project => project.Id == projectId);
            return projectDb;
        }

        public Project UpdateProject(int projectId, Project project)
        {
            var projectDb = _dbContext.Projects.Find(projectId);
            if (projectDb == null) throw new KeyNotFoundException();
            projectDb.Title = project.Title;
            projectDb.Description = project.Description;
            projectDb.StatusPost = project.StatusPost;
            //projectDb.Photos = project.Photos;
            //projectDb.Videos = project.Videos;
            projectDb.AwardPackages = project.AwardPackages;

            _dbContext.SaveChanges();
            return projectDb;
        }
    }
}
