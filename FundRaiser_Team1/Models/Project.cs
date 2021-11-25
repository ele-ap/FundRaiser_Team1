using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Model
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StatusPost { get; set; }
        public List<string> Photos { get; set; }
        public List<string> Videos { get; set; }

        public List<Package> AwardPackages { get; set; }
        public List<Backer> Backers { get; set; }
        public Creator ProjectCreator { get; set; }
    }
}
