using FundRaiser_Team1.Models;
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
        public Project CreateProject(int creatorId)
        {
            var creator = _dbContext.Creator.Find(creatorId);
            if (creator is null) return null;
            var project = new Project()
            {
                ProjectCreator = creator            
            };
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

        public List<Backer> GetBackers(int projectId)
        {
            var projectDb = _dbContext.Projects.Find(projectId).Include(b => b.Backers);

            return projectDb.Backers;
        }

        public Creator GetCreator(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<Package> GetPackages(int projectId)
        {
            throw new NotImplementedException();
        }

        public Project GetProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public Project UpdateProject(int projectId, Project project)
        {
            throw new NotImplementedException();
        }
    }
}
