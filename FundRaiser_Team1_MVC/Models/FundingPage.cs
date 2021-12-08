using FundRaiser_Team1.Models;

namespace FundRaiser_Team1_Mvc.Models
{
    public class FundingPage
    {
        public Project project { get; set; }
        public int FundersCount { get; set; }
        public float Money { get; set; }
    }
}
