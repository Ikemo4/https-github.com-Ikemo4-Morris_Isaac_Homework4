using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Morris_Isaac_Homework4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Morris_Isaac_Homework4.Controllers
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
            List<string> restaurantList = new List<string>();
            foreach (Restaurant r in Restaurant.loadRestaurants())
            {
                restaurantList.Add($"Rank: {r.Rank} | Name: {r.Name} | Favorite Dish: {r.FavoriteDish} | Address: {r.Address} | Phone: {r.Phone} | Website: {r.Website}");
            }
            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestions(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(restaurant);
                return RedirectToAction("ShowSuggestions");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ShowSuggestions()
        {
            List<string> restaurantList = new List<string>();
            foreach (Restaurant r in TempStorage.Restaurants)
            {
                restaurantList.Add($"Name: {r.Name} | Favorite Dish: {r.FavoriteDish} | Phone: {r.Phone}");
            }
            return View(restaurantList);
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
