using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParfumeOnlineShop.Interfaces;
using ParfumeOnlineShop.Models;
using ParfumeOnlineShop.ViewModel;

namespace ParfumeOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IParfumeRepository _parfumeRepository;

        public HomeController(IParfumeRepository parfumeRepository)
        {
            _parfumeRepository = parfumeRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ParfumesOfTheMonth = _parfumeRepository.ParfumeOfTheMonth
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
