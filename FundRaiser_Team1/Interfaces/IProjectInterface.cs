using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{
    public interface IProjectService
    {
        public Project CreateProject(int creatorId);
        public Project GetProject(int projectId);
        public List<Project> GetAllProjects(int pageCount, int pageSize);
        public Project UpdateProject(int projectId, Project project);
        public bool DeleteProject(int projectId);
        public List<Package> GetPackages(int projectId);
        public List<User> GetBackers(int projectId);
        public User GetCreator(int projectId);
    }
}
