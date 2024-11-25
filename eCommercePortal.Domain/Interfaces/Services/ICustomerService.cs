using eCommercePortal.Domain.Entites;
using eCommercePortal.Domain.Models.Request;
using eCommercePortal.Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePortal.Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<bool> PurchaseGroceries(CustomerRequest customer);
        Task<IEnumerable<CustomerResponse>> GetGroceries();
    }
}
