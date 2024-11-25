using eCommercePortal.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePortal.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<bool> PurchaseGroceries(Customer customer);
        Task<IEnumerable<Customer>> GetGroceries();
    }
}
