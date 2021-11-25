using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public User(string FirstName,string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
