using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Models
{
    public class Backer : User
    {
        public List<Project> FundedProjects { get; set; } = new List<Project>();

        
    }
}
