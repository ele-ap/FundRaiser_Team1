using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{
    public class UserService : IUserService
    {
        private readonly FundRaiserDbContext _db;

        public UserService(FundRaiserDbContext adbContext)
        {
            _db = adbContext;
        }

        public void CreateUser(User user)
        {
            _db.User.Add(user);
            try { _db.SaveChanges(); }
            catch { }
        }

        
        public User ReadUser(int id)
        {
            User user = _db.User.Find(id);
            return user;
        }

        public List<User> ReadCreatorAndBacker()
        {
            return _db.User.ToList();
        }

        
    }
}
