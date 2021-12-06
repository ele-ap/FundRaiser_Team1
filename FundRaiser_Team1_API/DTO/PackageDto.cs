using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundRaiser_Team1_API.DTO
{
    public class PackageDto
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public decimal PackagePrice { get; set; }
    }
}
