using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Models
{
    public class ProjectUser
    {
        [Key]
        public int ProjectUserId { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public Category CategoryProject { get; set; }

        public ProjectUser(int UserId, int ProjectId, Category categoryProject)
        {
            this.UserId = UserId;
            this.ProjectId = ProjectId;
            this.CategoryProject = categoryProject;
        }
    }

     
}
