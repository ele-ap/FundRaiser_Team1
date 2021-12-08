using FundRaiser_Team1.Interfaces;
using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{

    public class PackageService : IPackageService, IPackageUserService
    {
        private readonly FundRaiserDbContext _db;

        public PackageService(FundRaiserDbContext adbContext)
        {
            _db = adbContext;
        }

        public void CreatePackage(Package package)
        {
            _db.Package.Add(package);
            try { _db.SaveChanges(); }
            catch { }
        }

        public void CreatePackageUser(PackageUser packageUser)
        {
            _db.PackageUser.Add(packageUser);
            try { _db.SaveChanges(); }
            catch { }
        }

        public Package ReadPackage(int id)
        {
            Package package = _db.Package.Find(id);
            return package;
        }

        public List<Package> ReadPackages()
        {
            return _db.Package.ToList();
        }

        public PackageUser ReadPackageUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<PackageUser> ReadPackageUser()
        {
            throw new NotImplementedException();
        }
    }
}