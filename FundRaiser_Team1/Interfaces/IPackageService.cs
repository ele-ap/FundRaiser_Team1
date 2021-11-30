using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Services
{
	public interface IPackageService
	{
		public void CreatePackage(Packages package);
		public Packages ReadPackage(int id);
		public List<Packages> ReadPackages();
	}

}