using FundRaiser_Team1.Model;
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
        public Project UpdateProject(int projectId, Project project);
        public bool DeleteProject(int projectId);

    }
}
