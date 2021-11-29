using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team1.Models
{
    public enum Category
    {
        [Description("Creator")]
        CREATOR,
        [Description("Backer")]
        BACKER,
        [Description("Creator and Backer")]
        BOTH
    }
}
