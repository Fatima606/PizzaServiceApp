 using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using W2_D2_01.Models;
using static W2_D2_01.Models.Pizza;

namespace W2_D2_01.Controllers
{
    public class HomeController : Controller
    {
        

        [HttpGet]
        public IActionResult Index()
        {
            var _pizza = new Pizza();
            return View(_pizza);
        }
        [HttpPost]
        public IActionResult Index(Pizza model)
        {
            if (ModelState.IsValid)
            {
                // Process the selected pizza options
                return RedirectToAction("Index", model);
            }
            return View(model);
        }

    }
}