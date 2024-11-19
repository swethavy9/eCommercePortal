using eCommercePortal.Domain.Entites;
using eCommercePortal.Domain.Interfaces.Repositories;
using eCommercePortal.Domain.Interfaces.Services;
using eCommercePortal.Domain.Models.Request;
using eCommercePortal.Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePoral.BAL
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<IEnumerable<CustomerResponse>> GetGroceries()
        {
            var result = await _customerRepository.GetGroceries();
            return result.Select(x => new CustomerResponse
            {
                CustomerName = x.CustomerName,
                MobileNumber = x.MobileNumber,
                TotalAmount = x.Transactions.Select(txn => txn.Amount).Sum().Value,
                TotalRewardPoints = (int)x.Transactions.Select(txn => txn.RewardPoints).Sum().Value,
                Transactions = x.Transactions.Select(t => new TransactionResponse
                {
                    Amount = t.Amount,
                    CustomerMobileNumber = t.CustomerMobileNumber,
                    GroceryName = t.GroceryName,
                    Quantity = t.Quantity,
                    RewardPoints = t.RewardPoints,
                    TransactionId = t.TransactionId,
                    TransactionDate = t.TransactionDate
                }).ToList()

            });
        }


        public async Task<bool> PurchaseGroceries(CustomerRequest request)
        {
            var customer = new Customer
            {
                CustomerName = request.CustomerName,
                MobileNumber = request.CustomerMobileNumber,
                Transactions = request.Groceries.Select(x => new Transaction
                {
                    Amount = x.Amount,
                    CustomerMobileNumber = request.CustomerMobileNumber,
                    GroceryName = x.GroceryName,
                    Quantity = x.Quantity,
                    RewardPoints = x.RewardPoints,
                    TransactionDate = DateTime.Now
                }).ToList()
            };
            return await _customerRepository.PurchaseGroceries(customer);
        }
    }
}
