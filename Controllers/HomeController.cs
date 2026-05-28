using ClubFlow.Interfaces;
using ClubFlow.Models;
using ClubFlow.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClubFlow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _userRepository;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LoginRegister()
        {
            return View(new LoginRegisterViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginRegisterViewModel model, (object success, object errorMessage) value)
        {
            if (!ModelState.IsValid)
            {
                return View("LoginRegister", model);
            }

            var (success, errorMessage) = await _userRepository.RegisterUserAsync(model.registerLoginModel, model.user);
            if (!success)
            {
                ModelState.AddModelError(string.Empty, errorMessage);
                return View("LoginRegister", model);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginRegisterViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("LoginRegister", model);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }
        public IActionResult Messages()
        {
            return View();
        }
        public IActionResult Dates()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Products()
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
