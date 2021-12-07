using FundRaiser_Team1.Models;
using FundRaiser_Team1_API.DTO;
using FundRaiser_Team1_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_API.Services
{
    public class PackageService : IPackageService
    {
        private readonly FundRaiserDbContext _db;
        public PackageService(FundRaiserDbContext db)
        {
            _db = db;
        }
        public async Task<PackageDto> GetPackageById(int id)
        {
            Package package = await _db.Package.FindAsync(id);

            var dto = new PackageDto() {
                Description = package.Description,
                PackageName = package.PackageName,
                PackagePrice = package.PackagePrice
            };

            return dto;
        }
    }
}
