using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Models
{
    public class ProjectUser
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public Category Category { get; set; }
    }
}
