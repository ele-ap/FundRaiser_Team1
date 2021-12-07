using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Interfaces
{
    public interface IPackageUserService
    {
        public void CreatePackageUser(PackageUser packageUser);
        public PackageUser ReadPackageUser(int id);
        public List <PackageUser> ReadPackageUser();
        public bool DeletePackageUser(int projectUserId);
    }
}
