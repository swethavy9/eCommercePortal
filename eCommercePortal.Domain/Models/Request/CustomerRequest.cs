using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommercePortal.Domain.Utilities;

namespace eCommercePortal.Domain.Models.Request
{
    public class CustomerRequest
    {
        public string CustomerMobileNumber { get; set; }
        public string CustomerName { get; set; }
        public List<Groceries> Groceries { get; set; }
    }

    public class Groceries
    {
        public string GroceryName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal Amount { get; set; }

        public decimal? RewardPoints
        {
            get
            {
                return RewardCalculator.CalculatePoints(Amount);
            }
        }
    }
        
}
