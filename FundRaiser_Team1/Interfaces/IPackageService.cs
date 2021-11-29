using FundRaiser_Team1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{
	public interface IPackageService
	{
		public void CreatePackage(Package package);
		public Package ReadPackage(int id);
		public List<Package> ReadPackages();
	}

}