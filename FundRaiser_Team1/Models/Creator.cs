using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Models
{
    public class Creator : User
    {
        public Project CreatedProject { get; set; }
        public int CreatedProjectId { get; set; }

        public Creator()
        {

        }
        public Creator(string FirstName, string LastName, string Email) : base(FirstName, LastName , Email)
        {   
        }
    }
}
