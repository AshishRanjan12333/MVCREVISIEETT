using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCREVISIEETT.Models;

namespace MVCREVISIEETT.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext DbContext;
        public CustomerController(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public IActionResult Index()
        {
            List<Location> Location = DbContext.locations.ToList();

            return View(Location);
        }
        public IActionResult CustomerList(int Id)
        {
            List<Customer> customer = DbContext.customers.Where(e => e.location.Id == Id).ToList();
            return View(customer);
        }

    }
}


