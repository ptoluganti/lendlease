using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebLendLease
{
     public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();
    }
    
    [Route("/api/Customer")]
    public class CustomerController
    {
private static List<Customer> _customers = new List<Customer>(new[] {
            new Customer() { Id = 1, Name = "Computer" },
            new Customer() { Id = 2, Name = "Radio" },
            new Customer() { Id = 3, Name = "Apple" },
        });

        public IEnumerable<Customer> Get()
        {
            return _customers;
        }

    }
}