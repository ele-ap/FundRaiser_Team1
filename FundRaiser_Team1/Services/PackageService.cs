using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{

    public class PackageService : IPackageService
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

        public Package ReadPackage(int id)
        {
            Package package = _db.Package.Find(id);
            return package;
        }

        public List<Package> ReadPackages()
        {
            return _db.Package.ToList();
        }
    }
}