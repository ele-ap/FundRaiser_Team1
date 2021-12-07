using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_API.DTO
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Category Category { get; set; }
    }
}
