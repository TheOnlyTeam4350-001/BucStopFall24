using BucStop.Models;
using BucStop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

/*
 * This file has the controllers for everything outside of the games
 * and game-related pages.
 */

namespace BucStop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly ILogger<HomeController> _logger;
        private readonly GameService _gameService;
        private readonly VisitCountService _visitCountService;
        private readonly VisitCountManager _visitCountManager;

        public HomeController(ILogger<HomeController> logger, GameService gameService, VisitCountManager visitCountManager)
        {
            _logger = logger;
            _gameService = gameService;

            _visitCountManager = visitCountManager;
        }

        //Sends the user to the deprecated Index page.
        public IActionResult Index()
        {
            // Increment the visit count when someone visits the home page / index page
            _visitCountManager.IncrementVisitCount();

            // Retrieve the updated visit count
            int currentVisitCount = _visitCountManager.GetVisitCounts();

            // Pass the updated visit count to the view
            ViewData["VisitCount"] = currentVisitCount;

            // Fetch and pass game data
            var games = _gameService.GetGames();
            return View(games);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Load the visit count
            ViewData["VisitCount"] = _visitCountManager.GetVisitCounts();
            base.OnActionExecuting(context);
        }

        //Takes the user to the admin page.
        public IActionResult Admin()
        {
            return View();
        }

        //Takes the user to the about policy page.
        public IActionResult Privacy()
        {
            return View();
        }

        //Takes the user to the game criteria page.
        public IActionResult GameCriteria()
        {
            return View();
        }

        //Takes the user to version 2.1 page
        public IActionResult TwoDotOne()
        {
            return View();
        }

        public IActionResult TwoDotTwo()
        {
            return View();
        }

        public IActionResult TwoDotThree()
        {
            return View();
        }

        public IActionResult TwoDotFour()
        {
            return View();
        }

        //If something goes wrong, this will take the user to a page explaining the error.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}