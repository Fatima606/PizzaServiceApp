 using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using W2_D2_01.Models;
using static W2_D2_01.Models.Pizza;

namespace W2_D2_01.Controllers
{
    public class HomeController : Controller
    {
        private static int _totalPizzasOrdered = 0;
        private static List<Customer> _customers = new List<Customer>();
        [HttpGet]
        public IActionResult Index()
        {
            var _pizza = new Pizza();
            return View(_pizza);
        }
        [HttpPost]
        public IActionResult Index(Pizza model,int id)
        {
            if (ModelState.IsValid)
            {
                var customer = _customers.FirstOrDefault(c => c.CustomerId == id);

                if (customer == null)
                {
                    // Create a new customer if not found
                    customer = new Customer
                    {
                        CustomerId = _customers.Count + 1,
                        Order = model
                    };
                    _customers.Add(customer);
                    _totalPizzasOrdered++;
                }

                // Redirect to a summary page or another action
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult OrderSummary()
        {
            @ViewBag.TotalPizzasOrdered = _totalPizzasOrdered;
            return View(_customers);
        }
        public IActionResult FamousToppings()
        {
            return View(_customers);
        }

    }
}