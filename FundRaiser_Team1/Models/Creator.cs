using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Models
{
    public class Creator : User
    {
        public List<Project> CreatedProjects { get; set; } = new();
        public Creator(string FirstName, string LastName) : base(FirstName, LastName)
        {   
        }
    }
}
