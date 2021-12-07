using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Models
{
    public class PackageUser
    {
        [Key]
        public int PackageUserId { get; set; }
        public int UserId { get; set; }
        public int PackageId { get; set; }
    }
}
