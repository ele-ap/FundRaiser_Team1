﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Models
{

	public class Package
	{
		public int Id { get; set; }
		public string PackageName { get; set; }
		public string Description { get; set; }
		public decimal PackagePrice { get; set; }
		public List<Project> Projects { get; set; }
	}
}