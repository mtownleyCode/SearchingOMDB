using Microsoft.AspNetCore.Mvc;
using SearchingOMDB.Models;
using System.Diagnostics;

namespace SearchingOMDB.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieSearchForm(Rootobject movieList)
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieNightForm() 
        { 
            return View(); 
        }

        [HttpPost]
        public IActionResult MovieSearchResults(string titleToSearch)
        {
            Rootobject movieList = MovieDAL.GetMatchingMovies(titleToSearch);
            
            return View("MovieSearchForm", movieList);
        }

        [HttpPost]
        public IActionResult MovieNightResults(string movie1, string movie2, string movie3)
        {
            List<string> moviesToCheck = new List<string>()
            {
                movie1,
                movie2,
                movie3
            };

            List<Rootobject> fullMovieList = new List<Rootobject>();

            foreach (string movie in moviesToCheck) 
            {
                fullMovieList.Add(MovieDAL.GetMatchingMovies(movie));
            }

            return View("MovieNightForm", fullMovieList);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}