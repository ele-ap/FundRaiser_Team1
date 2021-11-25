using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{
    public class BackerService : IBackerService
    {
        private readonly FundRaiserDbContext _db;

        public BackerService(FundRaiserDbContext adbContext)
        {
            _db = adbContext;
        }
        public void CreateBacker(Backer backer)
        {
            _db.Backer.Add(backer);
            try { _db.SaveChanges(); }
            catch { }
        }

        public Backer ReadBacker(int id)
        {
            Backer backer = _db.Backer.Find(id);
            return backer;
        }

        public List<Backer> ReadBacker()
        {
            return _db.Backer.ToList();
        }
    }
}
