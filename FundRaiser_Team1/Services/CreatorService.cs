using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundRaiser_Team1.Models;
namespace FundRaiser_Team1.Services
{
    public class CreatorService : ICreatorService
    {
        private readonly FundRaiserDbContext _db;

        public CreatorService(FundRaiserDbContext adbContext)
        {
            _db = adbContext;
        }
        public void CreateCreator (Creator creator)
        {
            _db.Creator.Add(creator);
            try { _db.SaveChanges(); }
            catch { }
        }

        public Creator ReadCreator(int id)
        {
            Creator creator = _db.Creator.Find(id);
            return creator;
        }
       
        public List<Creator> ReadCreator()
        {
            return _db.Creator.ToList();
        }

        

    }
}
