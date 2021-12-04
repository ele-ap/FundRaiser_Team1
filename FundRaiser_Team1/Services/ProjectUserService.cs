using FundRaiser_Team1.Interfaces;
using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{
    public class ProjectUserService : IProjectUserService
    {

        private readonly FundRaiserDbContext _dbContext;

        public ProjectUserService(FundRaiserDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateProjectUser(ProjectUser projectUser)
        {
            _dbContext.ProjectUser.Add(projectUser);
            try { _dbContext.SaveChanges(); }
            catch { }
           
        }

        public ProjectUser ReadProjectUser(int id)
        {
            ProjectUser projectUser = _dbContext.ProjectUser.Find(id);
            return projectUser;
        }

        public List<ProjectUser> ReadProjectUser()
        {
            return _dbContext.ProjectUser.ToList();
        }
    }
}
