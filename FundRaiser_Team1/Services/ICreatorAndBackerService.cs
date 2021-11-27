using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FundRaiser_Team1.Services
{
    public interface ICreatorAndBackerService
    {
        public void CreateCreatorAndBacker(CreatorAndBacker creatorbacker);
        public CreatorAndBacker ReadCreatorAndBacker(int id);
        public List<CreatorAndBacker> ReadCreatorAndBacker();
    }
}
