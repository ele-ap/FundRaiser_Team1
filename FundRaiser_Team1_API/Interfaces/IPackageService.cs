using FundRaiser_Team1_API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_API.Interfaces
{
    public interface IPackageService
    {
        public Task<PackageDto> GetPackageById(int id);
        public Task<bool> DeletePackage(int id);
    }
}
