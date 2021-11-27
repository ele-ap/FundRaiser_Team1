using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{
    public class CreatorAndBackerService : ICreatorAndBackerService
    {
        private readonly FundRaiserDbContext _db;

        public CreatorAndBackerService(FundRaiserDbContext adbContext)
        {
            _db = adbContext;
        }

        public void CreateCreatorAndBacker(CreatorAndBacker creatorbacker)
        {
            _db.CreatorAndBacker.Add(creatorbacker);
            try { _db.SaveChanges(); }
            catch { }
        }

        
        public CreatorAndBacker ReadCreatorAndBacker(int id)
        {
            CreatorAndBacker creatorbacker = _db.CreatorAndBacker.Find(id);
            return creatorbacker;
        }

        public List<CreatorAndBacker> ReadCreatorAndBacker()
        {
            return _db.CreatorAndBacker.ToList();
        }

        
    }
}
