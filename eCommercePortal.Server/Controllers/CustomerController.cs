using eCommercePortal.Domain.Interfaces.Services;
using eCommercePortal.Domain.Models.Request;
using eCommercePortal.Domain.Models.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCommercePortal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService) {
            _customerService = customerService;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IEnumerable<CustomerResponse>> Get()
        {
            return await _customerService.GetGroceries();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<bool> Post([FromBody] CustomerRequest payload)
        {
          return await _customerService.PurchaseGroceries(payload);
        }
    }
}
