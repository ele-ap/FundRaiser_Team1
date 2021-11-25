using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundRaiser_Team1.Models;
namespace FundRaiser_Team1.Services
{
    public interface ICreatorService
    {
       
            public void CreateCreator(Creator creator);
            public Creator ReadCreator(int id);
        // public Creator DeleteCreator(int id);
        public List<Creator> ReadCreator();


    }
}
