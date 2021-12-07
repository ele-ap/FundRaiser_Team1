using FundRaiser_Team1.Models;
using FundRaiser_Team1_API.DTO;
using FundRaiser_Team1_API.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        public async Task<bool> DeletePackage(int id)
        {
            Package package = await _db.Package
                .SingleOrDefaultAsync(p => p.Id == id);
            if (package == null) return false;
            _db.Remove(package);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<PackageDto> UpdatePackage(int packageId, PackageDto dto)
        {
            Package package = await _db.Package
                                       .SingleOrDefaultAsync(p => p.Id == packageId);

            if (package is null) return null;

            if (dto.PackageName is not null) package.PackageName = dto.PackageName;
            if (dto.Description is not null) package.Description = dto.Description;
            if (dto.PackagePrice != 0) package.PackagePrice = dto.PackagePrice;

            await _db.SaveChangesAsync();

            PackageDto new_dto = new() {
                PackageName = package.PackageName,
                Description = package.Description,
                PackagePrice = package.PackagePrice
            };

            return new_dto;
        }
    }
}
