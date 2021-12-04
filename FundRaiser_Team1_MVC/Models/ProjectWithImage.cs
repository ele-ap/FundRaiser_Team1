using FundRaiser_Team1.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_Mvc.Models
{
    public class ProjectWithImage
    {
        public Project Project { get; set; }
        public IFormFile ProjectImage { set; get; }
    }
}
