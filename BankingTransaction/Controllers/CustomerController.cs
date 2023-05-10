using BankingTransaction.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankingTransaction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _configuration;

        public CustomerController(DataContext configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get(int userId)
        {
            var customers = await _configuration.Customers
                .Where(c => c.customerId == userId)
                .Include(c => c.Account)
                .Include(c => c.Transaction)
                .ToListAsync();

            return customers;
        }

        [HttpPost("register")]
        public async Task<ActionResult<List<Customer>>> CustomerRegister(UserRegDto request)
        {
            var customer = await _configuration.Customers.FindAsync(request.customerId);

            if (customer == null)
                return NotFound();

            var newCustomer = new Customer
            {
                customerName = request.customerName,
                customerNIC = request.customerNIC,
                customerEmail = request.customerEmail,
                customerPhone = request.customerPhone,
                Password = request.Password

            };

            //CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            //user.Username = request.Username;
            //user.PasswordHash = passwordHash;
            //user.PasswordSalt = passwordSalt;

            _configuration.Customers.Add(newCustomer);
            await _configuration.SaveChangesAsync();

            return await Get(newCustomer.customerId);
        }
    }
}
