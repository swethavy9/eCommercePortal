using eCommercePortal.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePortal.Domain.Models.Response
{
    public class CustomerResponse
    {
        public string MobileNumber { get; set; }

        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public int TotalRewardPoints { get; set; }

        public List<TransactionResponse> Transactions { get; set; } = new List<TransactionResponse>();
    }

    public class TransactionResponse
    {
        public int TransactionId { get; set; }

        public string CustomerMobileNumber { get; set; }

        public string GroceryName { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? RewardPoints { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
