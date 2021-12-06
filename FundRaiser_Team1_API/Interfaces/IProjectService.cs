using FundRaiser_Team1_API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_API.Interfaces
{
    public interface IProjectService
    {
        public Task<ProjectDto> GetProject(int id);
        public Task<List<ProjectDto>> GetAllProjects();
        public Task<bool> DeleteProject(int id);
        public List<UserDto> GetFunders();
        public UserDto GetCreator(int projectId);
    }
}
