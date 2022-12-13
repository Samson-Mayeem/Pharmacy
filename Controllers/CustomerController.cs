using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using samPharma.Data;
using samPharma.Models;

namespace samPharma.Controllers
{
    public class CustomerController : Controller
    {
        private readonly samDbContext SamDbContext;
        public CustomerController(samDbContext SamDbContext)
        {
            this.SamDbContext = SamDbContext;   
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var customer = await SamDbContext.customer.ToListAsync();
            return View(customer);
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            var cust = new Customer
            {
                Customer_Id = customer.Customer_Id,
                Customer_Reference = customer.Customer_Reference,
                Customer_Name = customer.Customer_Name,
                Customer_Address = customer.Customer_Address,
                Customer_Contact = customer.Customer_Contact,
                Customer_ImageUrl = customer.Customer_ImageUrl,
            };
            await SamDbContext.AddAsync(cust);
            await SamDbContext.SaveChangesAsync();
            return RedirectToAction("Index","CustomerSummary");
        }
    }
}
