using FundRaiser_Team1.Models;
using FundRaiser_Team1_API.DTO;
using FundRaiser_Team1_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_API.Services
{
    public class UserService : IUserService
    {
        private readonly FundRaiserDbContext _db;
        public UserService(FundRaiserDbContext db)
        {
            _db = db;
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var user = await _db.User.FindAsync(id);

            if (user == null) return null;

            var dto = new UserDto() 
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Category = user.Category
            };

            return dto;
        }
    }
}
