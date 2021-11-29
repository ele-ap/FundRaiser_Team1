using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Packages
{
	public int Id { get; set; }
	public string PackageName { get; set; }
	public string Description { get; set; }
	public decimal PackagePrice { get; set; }
	public List<Project> Projects { get; set; }

}
