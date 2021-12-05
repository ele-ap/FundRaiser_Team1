using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Interfaces
{
    public interface IProjectUserService
    {
        public void CreateProjectUser(ProjectUser projectUser);
        public ProjectUser ReadProjectUser(int id);
        public List<ProjectUser> ReadProjectUser();
        public bool DeleteProjectUser(int projectUserId);
    }
}
