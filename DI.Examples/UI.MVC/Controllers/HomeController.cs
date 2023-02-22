using BL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            bool isPreferredCustomer = this.User.IsInRole("PreferredCustomer");

            var service = new ProductService();

            var products = service.GetFeaturedProducts(isPreferredCustomer);

            this.ViewData["Products"] = products;

            return View();
        }
    }
}