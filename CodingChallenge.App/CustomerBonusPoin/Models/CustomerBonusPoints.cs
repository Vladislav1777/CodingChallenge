using System.Collections.Generic;

namespace CodingChallenge.App.CustomerBonusPoin.Models
{
    public class CustomerBonusPoints
    {
        public int CustomerId { get; set; }
        public List<BonusPoint> BonusPoints { get; set; }
        public decimal TotalBonusPoints { get; set; }
    }
}
