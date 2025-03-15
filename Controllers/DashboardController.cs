using ClubFlow.Interfaces;
using ClubFlow.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClubFlow.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        public IActionResult NewsFeed()
        {
            return View();
        }

        public IActionResult Clubs()
        {
            return View();
        }

        public IActionResult Account()
        {
            return View();
        }
        public IActionResult Settings()
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
