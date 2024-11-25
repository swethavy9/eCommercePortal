using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePortal.Domain.Utilities
{
    public class RewardCalculator
    {
        public static int CalculatePoints(decimal amount)
        {
            int points = 0;
            if (amount > 100)
            {
                points += (int)((amount - 100) * 2);  // 2 points for each dollar over $100
                points += 50 *1 ;
            }

            if (amount < 100 && amount > 50)
            {
                points += (int)((amount - 50) * 1);  // 1 point for each dollar over $50
            }

            return points;
        }
    }
}
