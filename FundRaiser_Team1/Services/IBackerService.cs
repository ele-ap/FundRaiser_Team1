using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{
    public interface IBackerService
    {
        public void CreateBacker(Backer backer);
        public Backer ReadBacker(int id);
        
        public List<Backer> ReadBacker();
    }
}
