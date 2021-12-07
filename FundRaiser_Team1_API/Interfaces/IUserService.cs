using FundRaiser_Team1.Models;
using FundRaiser_Team1_API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_API.Interfaces
{
    public interface IUserService
    {
        public Task<UserDto> GetUserById(int id); 
    }
}
