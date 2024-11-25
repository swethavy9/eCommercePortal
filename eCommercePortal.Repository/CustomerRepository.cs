using eCommercePortal.Domain.Entites;
using eCommercePortal.Domain.Interfaces.Repositories;
using eCommercePortal.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePortal.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private eCommerceContext _context;
        public CustomerRepository(eCommerceContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Customer>> GetGroceries()
        {
            return await _context.Customers.Include(x=>x.Transactions).ToListAsync();
        }

        public async Task<bool> PurchaseGroceries(Customer customer)
        {
            var customerInfo = _context.Customers.Where(x => x.MobileNumber == customer.MobileNumber).FirstOrDefault();
            if (customerInfo != null)
            {
                await _context.AddRangeAsync(customer.Transactions);
            }
            else
            {
                await _context.AddAsync(customer);
            }
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
